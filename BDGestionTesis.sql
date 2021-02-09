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
	DNI varchar(8),
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
)
go
create table TTipoTramite
(	 -- lista de atributos
	CodTramite varchar(10),
	Nombre varchar (50) not null,
	-- definicion de la clave primaria
	primary key (CodTramite)
)
go
create table TRequisitos
(	 -- lista de atributos
	CodRequisito varchar(10),
	Nombre varchar (100) not null,
	Descripcion varchar (300),
	-- definicion de la clave primaria
	primary key (CodRequisito),
			-- definicion de la clave foranea
)
go
create table TRequisitosXTramite
(
	CodTramite varchar(10),
	CodRequisito varchar(10),
	foreign key (CodRequisito) references TRequisitos,
	foreign key (CodTramite) references TTipoTramite
)
go
-- Tabla para Docente
create table TDocente
(	-- lista de atributos
	CodDocente varchar(10),
	DNI varchar(8),
	Apellidos varchar(50),
	Nombres varchar(50),
	GradoAcademico varchar(20),
	categoria varchar(20),
	Correo varchar(50),
	NumeroCelular varchar(10),
	Cargo Varchar(20)        default 'Docente'
                        Check (Cargo in ('Docente','Evaluador','Dictaminante','Jurado','Asesor','Directora')),
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
	Estado varchar(17),
	FechaInicio Datetime,
	CodTramite varchar(10),
	CodTesis varchar(10),
	-- definicion de la clave primaria
	primary key (NroExpediente),
	-- definicion de la clave foranea
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
create table TPreinscripcion
(	CodTesista1 varchar(10),
	CodTesista2 varchar(10),
	CodTesista3 varchar(10),
	foreign key (CodTesista1) references TTesista,
	foreign key (CodTesista2) references TTesista,
	foreign key (CodTesista3) references TTesista,
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
insert into TTesista values('150875','JHON EDWIN','TACUSI LAROTA','72212772','931328442','150408@unsaac.edu.pe','Bachiller')
insert into TTesista values('142358','ANGEL','QUISPE FLORES','72413452','954543432','145322@unsaac.edu.pe','Estudiante')
insert into TTesista values('164249','FLOR SHARMELY','TURCO CHAMPI','70566554','931232434','154453@unsaac.edu.pe','Bachiller')
insert into TTesista values('157677','FLOR ELISABET','USCA MOREANO','70655432','956344323','123434@unsaac.edu.pe','Estudiante')
insert into TTesista values('164250','ANTONIO','PARQUE ARCE','85454233','923284342','167443@unsaac.edu.pe','Bachiller')
insert into TTesista values('164849','MARCO','PARUA PECHO','77467875','931462722','167443@unsaac.edu.pe','Bachiller')
insert into TTesista values('184276','PERCY','REYES ROBLES','73455454','937374322','176548@unsaac.edu.pe','Bachiller')
insert into TTesista values('174258','ANTONI','USCA MOREANO','70655432','952233432','136533@unsaac.edu.pe','Estudiante')
insert into TTesista values('159831','PEDRO','ALCA CUSI','71334342','999643234','112324@unsaac.edu.pe','Bachiller')
insert into TTesista values('194857','BRUNO','PEREZ CHAWA','85454233','963122123','154621@unsaac.edu.pe','Estudiante')
go 
-------------------------------------------------------------------
-- inserción de datos en la tabla TESIS --

-------------------------------------------------------------------
insert into TTesis values('TE0001','Algoritmo de optimización basado en el comportamiento social de las arañas para clustering ','INTELIGENCIA ARTIFICIAL','Inicio','T0001')
insert into TTesis values('TE0002','Análisis estadistico de  saturacion de red en departamento de Cusco','REDES','Finalizado','T0002')
insert into TTesis values('TE0003','Análisis comparativa y diseño de una red 4G LTE en la provincia del Cusco empleando software de radioenlace ','REDES Y TELEPROCESOS','Inicio','T0003')
insert into TTesis values('TE0004','Análisis de métodos de visión computacional y Machine Learning para la clasificación de imágenes de variedades de papa nativa ﻿','INTELIGENCIA ARTIFICIAL','Inicio','T0004')
insert into TTesis values('TE0005','Análisis masivo de datos en twitter para identificación de opinión ﻿','INTELIGENCIA ARTIFICIAL','Inicio','T0005')
-------------------------------------------------------------------
-- inserción de datos en la tabla Docentes --
-------------------------------------------------------------------
insert into TDocente values('D0000','23423312','ACURI USCA','NILA SONIA','MAGISTER','NOMBRADO','nila.sonia@unsaac.edu.pe','942323879','Directora')
insert into TDocente values('D0001','24542345','RIBAS PUGA','ABDON','LICENCIADO','NOMBRADO','abdon.rivas@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0002','24542346','CARDENAS MAITA','ANA ROCIO','MAGISTER','CONTRATADO','ana.cardenas@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0003','24542347','CANDIA OVIEDO','DENNIS IVAN','INGENIERO','NOMBRADO','dennis.candia@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0004','24542348','AGUIRRE CARBAJAL ','DORIS SABINA','LICENCIADA','CONTRATADO','doris.aguirre@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0005','24542349','CARRASCO POBLETE','EDWIN','MAGISTER','NOMBRADO','edwincarrasco@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0006','24542350','CUTIPA ARAPA','EFRAINA GLADYS','INGENIERO','CONTRATADO','efraina.cutipa@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0007','24542351','PALOMINO OLIVERA','EMILIO','MAGISTER','NOMBRADO','emiliopalomino@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0008','24542352','GAMARRA SALDIVAR','ENRIQUE','MAGISTER','NOMBRADO','enrique.gamarra@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0009','24542353','PACHECO VASQUEZ ','ESTHER CRISTINA','LICENCIADA','NOMBRADO','esther.pacheco@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0010','24542354','TICONA PARI','GUZMAN','INGENIERO','NOMBRADO','guzman.ticona@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0011','24542355','VERA OLIVERA','HARLEY','MAGISTER','CONTRATADO','harley.vera@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0012','24542356','DUEÑAS DE LA CRUZ','HENRY SAMUEL','INGENIERO','CONTRATADO','henry.duenas@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0013','24542357','CASTAÑEDA CHIRINOS','HERNAN','INGENIERO','CONTRATADO','dhernan.castaneda@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0014','24542358','MEDRANO VALENCIA ','IVAN CESAR','INGENIERO','NOMBRADO','ivan.medrano@unsaac.edu.pe','932456879','Docente')
insert into TDocente values('D0015','24542359','ROZAS HUACHO','JAVIER ARTURO','MAGISTER','NOMBRADO','javier.rozas@unsaac.edu.pe','932456879','Docente')

go 
-- inserción de datos en la tabla TIPO DE TRAMITE
-------------------------------------------------------------------
insert into TTipoTramite values('0001','Inscripcion')
insert into TTipoTramite values('0002','Dictamen')
insert into TTipoTramite values('0003','Sustentacion')

go 
-- inserción de datos en la tabla TIPO DE TRAMITE
-------------------------------------------------------------------
insert into TRequisitos values('REQ0001','Ficha de seguimiento','ficha con las notas para verificar culminacion de semestre')
insert into TRequisitos values('REQ0002','Solicitud valorada','solicitar inscripcion hacia el rector')
insert into TRequisitos values('REQ0003','Solicitud de dictaminates','solicitar a decano dictaminates')
insert into TRequisitos values('REQ0004','Ejemplar de plan de tesis','entrega de una copia de plan de tesis')
insert into TRequisitos values('REQ0005','Ejemplar de Tesis','Ejemplar de la tesis')
go
-- inserción de datos en la tabla PROVEIDO
-------------------------------------------------------------------
insert into TProveido values('PV0001','12/12/12','D0001')
insert into TProveido values('PV0002','12/12/12','D0002')
insert into TProveido values('PV0003','13/05/15','D0003')
insert into TProveido values('PV0004','24/12/15','D0004')
insert into TProveido values('PV0005','24/12/15','D0005')
go
-- inserción de datos en la tabla DOCUMENTACION
-------------------------------------------------------------------
insert into TDocumentacion values('EX0001','Inicio','01/04/2012','0001','TE0001')
insert into TDocumentacion values('EX0002','Intermedio','01/08/2012','0002','TE0002')
insert into TDocumentacion values('EX0003','Inicio','01/02/2013','0001','TE0003')
insert into TDocumentacion values('EX0004','Intermedio','01/05/2013','0002','TE0004')
insert into TDocumentacion values('EX0005','Terminado','01/10/2013','0003','TE0005')
go
-- inserción de datos en la tabla RESOLUCION
-------------------------------------------------------------------
insert into TResolucion values('RES0001','11/08/2012','EX0002')
insert into TResolucion values('RES0002','21/05/2013','EX0004')
insert into TResolucion values('RES0003','01/10/2013','EX0005')

go
-- inserción de datos en la tabla PUBLICACION
-------------------------------------------------------------------
insert into TPublicacion values('PU0001','EX0001')
go
-- inserción de datos en la tabla TEvaluacionDePlanDeTesis
-------------------------------------------------------------------
insert into TEvaluacionDePlanDeTesis values('EV0001','16','15','16','17','16','15','17','18','18','de 0 a 20','Excelente trabajo corregir errores ortagrafico minimos','PV0001','D0001')
insert into TEvaluacionDePlanDeTesis values('EV0002','16','15','16','17','16','15','17','18','18','de 0 a 20','Excelente trabajo corregir errores ortagrafico minimos','PV0002','D0002')
insert into TEvaluacionDePlanDeTesis values('EV0003','16','15','16','17','16','15','17','18','18','de 0 a 20','Excelente trabajo corregir errores ortagrafico minimos','PV0003','D0003')
insert into TEvaluacionDePlanDeTesis values('EV0004','16','15','16','17','16','15','17','18','18','de 0 a 20','Excelente trabajo corregir errores ortagrafico minimos','PV0004','D0004')
insert into TEvaluacionDePlanDeTesis values('EV0005','16','15','16','17','16','15','17','18','18','de 0 a 20','Excelente trabajo corregir errores ortagrafico minimos','PV0005','D0005')
go
-- inserción de datos en la tabla TEvaluacionDeDictamenDeTesis
-------------------------------------------------------------------

go
-- inserción de datos en la tabla TEvaluacionDeSustentacionDeTesis
-------------------------------------------------------------------

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
