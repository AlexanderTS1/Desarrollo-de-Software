--------------------------------------------------------------------------
---- CREACION DE LA BASE DE DATOS
--------------------------------------------------------------------------
use master
go
if exists (select * from sysdatabases where name = 'DBGestionTesis')
	drop database DBGestionTesis
go
create database DBGestionTesis
go
--------------------------------------------------------------------------
-- CREACION DE LA TABLA LIBRO
--------------------------------------------------------------------------
use DBGestionTesis
go
-- Tabla para Usuarios
create table TTesista
(	 -- lista de atributos
	CodTesista varchar(10) NOT NULL,
	Nombre varchar (50) not null,
	Apellido varchar(50) not null,
	DNI varchar(15),
	telefono varchar (20) not null,
	CorreoElectronico varchar(30) not null,
	GradoAcademico Varchar(20)        default 'Estudiante'
                        Check (GradoAcademico in ('Estudiante','Bachiller')),
	-- definicion de la clave primaria
	primary key (CodTesista)
)
go
create table TTesis
(	 -- lista de atributos
	CodTesis varchar(10),
	Titulo varchar (500) not null,
	especialidad varchar(100),
	Estado varchar(30),
	CodTesista varchar(10) not null,
	-- definicion de la clave primaria
	primary key (CodTesis),
		-- definicion de la clave foranea
	foreign key (CodTesista) references TTesista
)
go
create table TTipoTramite
(	 -- lista de atributos
	CodTramite varchar(10) not null,
	Nombre varchar (50) not null,
	-- definicion de la clave primaria
	primary key (CodTramite)
)
go
create table TRequisitos
(	 -- lista de atributos
	CodRequisito varchar(10) not null,
	Nombre varchar (50) not null,
	Descripcion varchar (30),
	CodTramite varchar(10),
	-- definicion de la clave primaria
	primary key (CodRequisito),
			-- definicion de la clave foranea
	foreign key (CodTramite) references TTipoTramite
)

go
-- Tabla para Docente
create table TDocente
(	-- lista de atributos
	CodDocente varchar(10),
	DNI varchar(10),
	Apellidos varchar(50),
	Nombres varchar(50),
	Correo varchar(50),
	NumeroCelular varchar(10),
	Cargo Varchar(20)        default 'Docente'
                        Check (Cargo in ('Docente','Evaluador','Dictaminante','Jurado','Asesor','director')),
	-- definicion de la clave primaria
	primary key (CodDocente),
		-- definicion de la clave foranea

)
go
create table TProveido
(	-- lista de atributos
	CodProveido varchar(10),
	FechaGeneracion datetime,
	CodDocente varchar(10),
	-- definicion de la clave primaria
	primary key (CodProveido),
		-- definicion de la clave foranea
	foreign key (CodDocente) references TDocente
)

go

-- Tabla para Documentacion
create table TDocumentacion
(	-- lista de atributos
	NroExpediente varchar(10),
	CodDocenteDirector varchar(10),
	Estado varchar(17),
	FechaInicio Datetime,
	TipoTramite varchar(50),
	CodProveido varchar(10),
	CodTramite varchar(10),
	CodTesis varchar(10),
	-- definicion de la clave primaria
	primary key (NroExpediente),
	-- definicion de la clave foranea
	foreign key (CodProveido) references TProveido,
	foreign key (CodTramite) references TTipoTramite,
	foreign key (CodTesis) references TTesis,
)

go
-- Tabla para Usuarios
create table TResolucion
(	 -- lista de atributos
	CodResolucion varchar(10) NOT NULL,
	FechaGeneracion datetime,
	NroExpediente varchar(10),
	-- definicion de la clave primaria
	primary key (CodResolucion),
		-- definicion de la clave foranea
	foreign key (NroExpediente) references TDocumentacion
)

go
create table TPublicacion
(	-- lista de atributos
	NroPublicacion varchar(10),
	NroExpediente varchar(10),
	-- definicion de la clave primaria
	primary key (NroPublicacion),
		-- definicion de la clave foranea
	foreign key (NroExpediente) references TDocumentacion
)

go
create table TEvaluacionDeSustentacionDeTesis
(	-- lista de atributos
	CodSustentacionDeTesis varchar(10),
	NotaPresentacionDeFormaDelTrabajoDeInvestigacion Varchar(3)        default 'NSP'
                        Check (NotaPresentacionDeFormaDelTrabajoDeInvestigacion in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	NotaDominioDelTema Varchar(3)        default 'NSP'
                        Check (NotaDominioDelTema in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	NotaCapacidadDeSintesisEnLaExposicion Varchar(3)        default 'NSP'
                        Check (NotaCapacidadDeSintesisEnLaExposicion in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	NotaDesemvolvimientoEnLaAbsolucionDeLasPreguntas Varchar(3)        default 'NSP'
                        Check (NotaDesemvolvimientoEnLaAbsolucionDeLasPreguntas in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	Observacion varchar(500),
	CodDocente varchar(10),
	CodResolucion varchar(10),
	-- definicion de la clave primaria
	primary key (CodSustentacionDeTesis),
		-- definicion de la clave foranea
	foreign key (CodDocente) references TDocente,
	foreign key (CodResolucion) references TResolucion,
)

go
create table TEvaluacionDeDictamenDeTesis
(	-- lista de atributos
	CodDictamenDeTesis varchar(10),
	CalificacionDeDictamen varchar(10),
	Observacion varchar(500),
	CodDocente varchar(10),
	CodResolucion varchar(10),
	-- definicion de la clave primaria
	primary key (CodDictamenDeTesis),
		-- definicion de la clave foranea
	foreign key (CodDocente) references TDocente,
	foreign key (CodResolucion) references TResolucion,
)

go
create table TEvaluacionDePlanDeTesis
(	-- lista de atributos
	NroEvaluacionDePlanDeTesis varchar(10),
	NotaIdentificacionDelProblema Varchar(3)        default 'NSP'
                        Check (NotaIdentificacionDelProblema in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	NotaHipotesis Varchar(3)        default 'NSP'
                        Check (NotaHipotesis in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	NotaAlcanceyResultados Varchar(3)        default 'NSP'
                        Check (NotaAlcanceyResultados in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	NotaMetodologia Varchar(3)        default 'NSP'
                        Check (NotaMetodologia in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	NotaRevisionBibliografica Varchar(3)        default 'NSP'
                        Check (NotaRevisionBibliografica in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	NotaRecursosyPresupuestos Varchar(3)        default 'NSP'
                        Check (NotaRecursosyPresupuestos in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	NotaImpacto Varchar(3)        default 'NSP'
                        Check (NotaImpacto in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	NotaDeOrganizacionDeDocumentoDePlan Varchar(3)        default 'NSP'
                        Check (NotaDeOrganizacionDeDocumentoDePlan in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	NotaPresentacionGeneralDelDocumentoDelPlan Varchar(3)        default 'NSP'
                        Check (NotaPresentacionGeneralDelDocumentoDelPlan  in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
	EscalaValoracion varchar(100),
	Observacion varchar(500),
	CodProveido varchar(10),
	CodDocente varchar(10),

	-- definicion de la clave primaria
	primary key (NroEvaluacionDePlanDeTesis),
		-- definicion de la clave foranea
	foreign key (CodProveido) references TProveido,
	foreign key (CodDocente) references TDocente,
)

go
set dateformat dMy
-------------------------------------------------------------------
-- inserción de datos en la tabla TESISTAS 
-------------------------------------------------------------------
insert into TTesista values('T0001','JHON EDWIN','TACUSI LAROTA','72212772','931328442','150408@unsaac.edu.pe','Bachiller')
insert into TTesista values('T0002','ANGEL','QUISPE FLORES','72413452','954543432','145322@unsaac.edu.pe','Estudiante')
insert into TTesista values('T0003','FLOR SHARMELY','TURCO CHAMPI','70566554','931232434','154453@unsaac.edu.pe','Bachiller')
insert into TTesista values('T0004','FLOR ELISABET','USCA MOREANO','70655432','956344323','123434@unsaac.edu.pe','Estudiante')
insert into TTesista values('T0005','ANTONIO','PARQUE ARCE','85454233','923284342','167443@unsaac.edu.pe','Bachiller')
go 
-------------------------------------------------------------------
-- inserción de datos en la tabla TESIS --

-------------------------------------------------------------------
insert into TTesis values('TE0001','Algoritmo de optimización basado en el comportamiento social de las arañas para clustering ','INTELIGENCIA ARTIFICIAL','Inicio','T0001')
insert into TTesis values('TE0002','Análisis estadistico de  saturacion de red en departamento de Cusco','REDES','Finalizado','T0003')
-------------------------------------------------------------------
-- inserción de datos en la tabla Docentes --
-------------------------------------------------------------------
insert into TDocente values('D0001','24542345','RIBAS PUGA','ABDON','abdon.rivas@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('C0002','24542346','CARDENAS MAITA','ANA ROCIO','ana.cardenas@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('C0003','24542347','CANDIA OVIEDO','DENNIS IVAN','dennis.candia@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('C0004','24542348','AGUIRRE CARBAJAL ','DORIS SABINA','doris.aguirre@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('C0005','24542349','CARRASCO POBLETE','EDWIN','edwincarrasco@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0006','24542350','CUTIPA ARAPA','EFRAINA GLADYS','efraina.cutipa@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('C0007','24542351','PALOMINO OLIVERA','EMILIO','emiliopalomino@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('C0008','24542352','GAMARRA SALDIVAR','ENRIQUE','enrique.gamarra@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('C0009','24542353','PACHECO VASQUEZ ','ESTHER CRISTINA','esther.pacheco@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('C0010','24542354','TICONA PARI','GUZMAN','guzman.ticona@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0011','24542355','VERA OLIVERA','HARLEY','harley.vera@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('C0012','24542356','DUEÑAS DE LA CRUZ','HENRY SAMUEL','henry.duenas@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('C0013','24542357','CASTAÑEDA CHIRINOS','HERNAN','dhernan.castaneda@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('C0014','24542358','MEDRANO VALENCIA ','IVAN CESAR','ivan.medrano@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('C0015','24542359','ROZAS HUACHO','JAVIER ARTURO','javier.rozas@unsaac.edu.pe','932456879','Docente')
go 
use DBGestionTesis
go
select * from TDocente
select * from TTesista
select * from TTesis
select * from TDocumentacion
select * from TPublicacion
select * from TEvaluacionDePlanDeTesis
select * from TEvaluacionDeDictamenDeTesis
select * from TEvaluacionDeSustentacionDeTesis
select * from TRequisitos
select * from TResolucion
select * from TTipoTramite
select * from TProveido

