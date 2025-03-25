--visualizzare alunni con assenze, assenze con alunni e assenze senza alunni	
select ALUNNI.idAlunno,cognome,nome,tipo,dataAssenza
from ALUNNI RIGHT join ASSENZE
on ALUNNI.idAlunno=assenze.idAlunno
--VIS ALUNNI CON VOTO DI INFO E ANCHE ALUNNI SENZA VOTO
SELECT ALUNNI.idAlunno,COGNOME,NOME,Voti.idMateria
from ALUNNI right join Voti
on ALUNNI.idAlunno=voti.idAlunno