using FagTilmeldingApp.Codes;
//iteration1
Console.Write("Angive skolenavn :");
string schoolnavn = Console.ReadLine();
Console.Write("Angiv Hoverforløb : ");
string semesterNavn= Console.ReadLine();
Console.Clear();
Semester se= new(schoolnavn, semesterNavn);
Console.WriteLine("=========================");
string arv = $"{schoolnavn},{semesterNavn} fag tilmeldning app";
Console.WriteLine(arv);
Console.WriteLine("==========================");
Console.ReadLine();
