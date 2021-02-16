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
	CodTesista varchar(6) check (CodTesista like '[0-9][0-9][0-9][0-9][0-9][0-9]'),
	Nombre varchar (50) not null,
	Apellido varchar(50) not null,
	CorreoElectronico varchar(30) not null,
	
	telefono varchar (20) check (telefono like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	DNI varchar(8) check (DNI like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	GradoAcademico Varchar(20)        default 'Estudiante'
                        Check (GradoAcademico in ('Estudiante','Bachiller','Egresado')),
	-- definicion de la clave primaria
	primary key (CodTesista)
)
go

go
-- Tabla para Docente
create table TDocente
(	-- lista de atributos
	CodDocente varchar(6),
	DNI varchar(8) check (DNI like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	Apellidos varchar(50),
	Nombres varchar(50),
	GradoAcademico varchar(20),
	categoria varchar(20),
	Correo varchar(50),
	NumeroCelular varchar(9) check (NumeroCelular like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	Cargo Varchar(20)        default 'Docente'
                        Check (Cargo in ('Docente','Evaluador','Dictaminante','Jurado','Asesor','Directora')),
	-- definicion de la clave primaria
	primary key (CodDocente),
		-- definicion de la clave foranea

)
--------------------------------------------------
create table TTesis
	( -- lista de atributos
	CodTesis varchar(6),
	Especialidad varchar(20),
	Titulo varchar(40),
	CodDocente varchar(6),
	Estado varchar (20)
	-- especificacio) de claves
	primary key (CodTesis),
)
go
create table TTramite
(	 -- lista de atributos
	CodTramite varchar(6),
	Tipo varchar(100),
	-- especificacion de claves
	primary key (CodTramite),
)
go
create table TRequisitos
(	 -- lista de atributos
	CodRequisito varchar(6),
	TipoRequisito varchar(100),

	-- especificacion de claves
	primary key (CodRequisito),
)
go
create table TRequisitosXTramite
(
	CodTramite varchar(6),
	CodRequisito varchar(6),
	foreign key (CodTramite) references TTramite,
	foreign key (CodRequisito) references TRequisitos,
)


create table TComisionRevisora
( -- lista de atributos
CodEvaluacionPlanTesis varchar(6),
CodDocente varchar(6),
-- especificacion de claves
foreign key (CodDocente) references TDocente
)

go

create table TDictaminantesDeTesis
( -- lista de atributos
CodDictamenDeTesis varchar(6),
CodDocente varchar(6),
-- especificacion de claves
primary key (CodDictamenDeTesis),
foreign key (CodDocente) references TDocente
)

go

create table TJuradoEvaluador
( -- lista de atributos
CodDictamenDeTesis varchar(6),
CodDocente varchar(6),
-- especificacion de claves
primary key (CodDictamenDeTesis),
foreign key (CodDocente) references TDocente
)
go
create table TProveido
(	-- lista de atributos
	CodProveido varchar(10),
	FechaGeneracion datetime,
	CodDocente varchar(6),
	-- definicion de la clave primaria
	primary key (CodProveido),
		-- definicion de la clave foranea
	foreign key (CodDocente) references TDocente
)

go

-- Tabla para Documentacion
create table TDocumentacion
(	-- lista de atributos
	NroExpediente varchar(6),
	CodTesis varchar(6) not null,
	CodEvaluacionPlanDeTesis varchar(6) ,
	CodDictamenDeTesis varchar(6) ,
	CodSustentacionOral varchar(6) ,
	Observacion varchar(40) not null,
	-- especificacion de claves
	primary key (NroExpediente),
	foreign key (CodTesis) references TTesis,
)

go
-- Tabla para Usuarios
create table TResolucion
(	 -- lista de atributos
	CodResolucion varchar(10) NOT NULL,
	FechaGeneracion datetime,
	NroExpediente varchar(6),
	-- definicion de la clave primaria
	primary key (CodResolucion),
		-- definicion de la clave foranea
	foreign key (NroExpediente) references TDocumentacion
)
go 
create table TPreinscripcion
(	CodTesista1 varchar(6),
	CodTesista2 varchar(6),
	CodTesista3 varchar(6),
	foreign key (CodTesista1) references TTesista,
	foreign key (CodTesista2) references TTesista,
	foreign key (CodTesista3) references TTesista,
)
go
create table TPublicacion
(	-- lista de atributos
	NroPublicacion varchar(10),
	NroExpediente varchar(6),
	-- definicion de la clave primaria
	primary key (NroPublicacion),
		-- definicion de la clave foranea
	foreign key (NroExpediente) references TDocumentacion
)

go
create table TEvaluacionDeSustentacionDeTesis
(	-- lista de atributos
	CodSustentacionDeTesis varchar(6),
	CodDocente varchar(6),
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
	CodDictamenDeTesis varchar(6),
	CalificacionDeDictamen varchar(10),
	Observacion varchar(500),
	CodDocente varchar(6),
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
	CodEvaluacionDePlanDeTesis varchar(6),
	CodDocente varchar(6),
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
	

	-- definicion de la clave primaria
	primary key (CodEvaluacionDePlanDeTesis),
		-- definicion de la clave foranea,
	foreign key (CodDocente) references TDocente,
)
go
create table TSolicitudInscripcion
(
CodSolitudInscripcionTesis varchar(6),--desde 800000
CodTramite varchar(6),
--CodTesista1 varchar(6),
--CodTesista2 varchar(6),
--CodTesista3 varchar(6),
CodTesis varchar(6),
Estado varchar(30),--Recibido--Resuelto
Observaciones varchar(100),
	--foreign key (CodTesista1) references TTesista
	--foreign key (CodTesista2) references TTesista
	--foreign key (CodTesista3) references TTesista
primary key (CodSolitudInscripcionTesis),
foreign key (CodTesis) references TTesis,
foreign key (CodTramite) references TTramite,
)
go 
create table TTesisPorTesista(
	CodTesis varchar(6),
	CodTesista varchar(6),
	foreign key (CodTesis) references TTesis,
	foreign key (CodTesista) references TTesista,
)
go
set dateformat dMy

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

----------------------------------------
-- INSERTAMOS DATOS A LAS TABLA TESISTA --
---------------------------------------
insert into TTesista values ('124813','DE LA CRUZ QUISPE','ALEX ALBERTO','124813@unsaac.edu.pe','996789497','24632532','Estudiante')
insert into TTesista values ('124219','VALLE HUAMAN','MARIA ANGELA','124219@unsaac.edu.pe','973789025','72634545','Estudiante')
insert into TTesista values ('150409','TTITO RAMOS','MANUEL DARIO','150409@unsaac.edu.pe','965783029','74234575','Estudiante')
insert into TTesista values ('134544','ZUNIGA HUAMAN','EDI FRAI','134544@unsaac.edu.pe','937159085','24632515','Estudiante')
insert into TTesista values ('113553','FLORES YUCRA','IGNACIO','113553@unsaac.edu.pe','928089096','74362845','Estudiante')
insert into TTesista values ('141670','HALIRE HUAMAN','JAIME ANDRE','141670@unsaac.edu.pe','915786032','24634198','Estudiante')
insert into TTesista values ('151827','LEVA SALAS ','RENAN FERDINANDN','151827@unsaac.edu.pe','918781227','70621528','Estudiante')
insert into TTesista values ('110125','LOPINTA HUAMAN','CRISTIAN RODRIGO','110125@unsaac.edu.pe','989289025','24769542','Estudiante')
insert into TTesista values ('155184','MAMANI CCANAHUIREL','LALO LEONEL','155184@unsaac.edu.pe','981789018','70625583','Estudiante')
insert into TTesista values ('154637','NINA PONCE','JOSUE JOSE','154637@unsaac.edu.pe','992789035','70689502','Estudiante')
insert into TTesista values ('141674','VILCA PANTIGOSO','KAROL BERLIZN','141674@unsaac.edu.pe','921793025','24689572','Estudiante')
insert into TTesista values ('133959','ANCCO PERALTA','JUAN ABEL','133959@unsaac.edu.pe','924398918','72964555','Estudiante')
insert into TTesista values ('151833','CONDE CHURA','YURI FERNANDO','151833@unsaac.edu.pe','925789088','24689354','Estudiante')
insert into TTesista values ('160893','OLAZABAL CALLER','LETICIA GIULIANA','160893@unsaac.edu.pe','919078902','70344501','Estudiante')
insert into TTesista values ('164240','ESCOBEDO DURAN','ROBERTO CARLOS','164240@unsaac.edu.pe','985783621','24615545','Egresado')
insert into TTesista values ('155185','PEZUA CERNADES','ARACELY','155185@unsaac.edu.pe','912689087','70384588','Egresado')
insert into TTesista values ('144993','IBARRA HUAMAN','ALEXANDER PAVEL','144993@unsaac.edu.pe','918709095','79625845','Egresado')
insert into TTesista values ('160545','NAOLA PEREYRA','ALEXANDER YERIM','160545@unsaac.edu.pe','973989025','70656582','Egresado')
insert into TTesista values ('150389','CONDE SALLO','JHACK STEVEN','150389@unsaac.edu.pe','923789089','24684582','Bachiller')
insert into TTesista values ('150543','DONGO ESQUIVEL','DIEGO YOSHIRO','150543@unsaac.edu.pe','912589025','72634565','Bachiller')




select * from TTesista


insert into TTesis values('500000','IA','TITULO DE TESIS 1','D0001','REVISION')
insert into TTesis values('500001','DS','TITULO DE TESIS 2','D0002','REVISION')
insert into TTesis values('500002','DS','TITULO DE TESIS 3','D0003','REVISION')
insert into TTesis values('500003','DS','TITULO DE TESIS 4','D0004','REVISION')
insert into TTesis values('500004','DS','TITULO DE TESIS 5','D0005','REVISION')
insert into TTesis values('500005','IA','TITULO DE TESIS 6','D0006','REVISION')
insert into TTesis values('500006','IA','TITULO DE TESIS 7','D0007','REVISION')
SELECT  * FROM TTesis
select CodTesis from TTesis



insert into TTramite values ('TR0001','Nombramiento de Asesor e Inscripcion de Plan de Tesis')
--insert into TTramite values ('TR0002','Solicitar Nombramiento de la Comision Revisora y su posterior Revision')
insert into TTramite values ('TR0002','Nombramiento de dictaminadores de Tesis y su posterior Dictamen')
insert into TTramite values ('TR0003','Sustentacion de Tesis')


insert into TRequisitos values ('REQ001','Solicitud Dirigida al Rector')
insert into TRequisitos values ('REQ002','Dos Ejemplares de Plan de Tesis refrendado por el Asesor')
insert into TRequisitos values ('REQ003','Carta de Aceptacion del Asesor')
insert into TRequisitos values ('REQ004','Ficha de Seguimiento Academico')
insert into TRequisitos values ('REQ005','Informe del Asesor')
insert into TRequisitos values ('REQ006','Resolucion de Aprobacion de Expediente de Titulo')
insert into TRequisitos values ('REQ007','Dos Ejemplares de Tesis Anillado')
insert into TRequisitos values ('REQ008','Certificado de Originalidad de la Tesis, firmado por el Asesor')
insert into TRequisitos values ('REQ009','Pago Por Derechos De Tramite')
insert into TRequisitos values ('REQ010','Copia de Resolucion de Aprobacion de Dictamen de Tesis')
insert into TRequisitos values ('REQ011','05 ejemplares de tesis ')

insert into TRequisitosXTramite values('TR0001' ,'REQ001')
insert into TRequisitosXTramite values('TR0001' ,'REQ002')
insert into TRequisitosXTramite values('TR0001' ,'REQ003')
insert into TRequisitosXTramite values('TR0001' ,'REQ004')

/*insert into TRequisitoXTramite values('TR0002' ,'REQ001')
insert into TRequisitoXTramite values('TR0002' ,'REQ002')
insert into TRequisitoXTramite values('TR0002' ,'REQ003')

select * from TTramite where CodTramite='TR0002'*/


delete from TTramite where CodTramite='TR0005'
insert into TRequisitosXTramite values('TR0002' ,'REQ001')
insert into TRequisitosXTramite values('TR0002' ,'REQ005')
insert into TRequisitosXTramite values('TR0002' ,'REQ006')
insert into TRequisitosXTramite values('TR0002' ,'REQ007')
insert into TRequisitosXTramite values('TR0002' ,'REQ008')
insert into TRequisitosXTramite values('TR0002' ,'REQ009')

insert into TRequisitosXTramite values('TR0003' ,'REQ001')
insert into TRequisitosXTramite values('TR0003' ,'REQ010')
insert into TRequisitosXTramite values('TR0003' ,'REQ011')
insert into TRequisitosXTramite values('TR0003' ,'REQ009')

select * from TDocumentacion


--Nombramiento de Asesor e Inscripcion de Plan de Tesis
--insert into TRequisito values ('REQ001','Solicitud Dirigida al Rector')
--insert into TRequisito values ('REQ002','Dos Ejemplares de Plan de Tesis refrendado por el Asesor')
--insert into TRequisito values ('REQ003','Carta de Aceptacion del Asesor')
--insert into TRequisito values ('REQ004','Ficha de Seguimiento Academico')

--Solicitar Nombramiento de la Comision Revisora y su posterior Revision
--insert into TRequisito values ('REQ001','Solicitud Dirigida al Rector')
--insert into TRequisito values ('REQ002','Dos Ejemplares de Plan de Tesis refrendado por el Asesor')
--insert into TRequisito values ('REQ003','Carta de Aceptacion del Asesor')

--Nombramiento de dictaminadores de Tesis
--insert into TRequisito values ('REQ001','Solicitud Dirigida al Rector')
--insert into TRequisito values ('REQ005','Informe del Asesor')
--insert into TRequisito values ('REQ006','Resolucion de Aprobacion de Expediente de Titulo')
--insert into TRequisito values ('REQ007','Dos Ejemplares de Tesis Anillado')
--insert into TRequisito values ('REQ008','Certificado de Originalidad de la Tesis, firmado por el Asesor')
--insert into TRequisito values ('REQ009','Pago Por Derechos De Tramite')

--Determinacion de Fecha, Hora y Lugar para Sustentacion de Tesis
--insert into TRequisito values ('REQ001','Solicitud Dirigida al Rector')
--insert into TRequisito values ('REQ010','Copia de Resolucion de Aprobacion de Dictamen de Tesis')
--insert into TRequisito values ('REQ011','05 ejemplares de tesis ')
--insert into TRequisito values ('REQ009','Pago por Derechos de Tramite')

---CONSULTAS
select * from TSolicitudInscripcion
select a.NroExpediente,a.CodEvaluacionPlanDeTesis,a.CodTesis,b.Titulo,b.Especialidad,b.Estado  
from TDocumentacion a inner join TTesis b on a.CodTesis=b.CodTesis where CodEvaluacionPlanDeTesis=''
select * from TComisionRevisora 
select * from  TDocumentacion 