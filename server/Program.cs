Console.WriteLine("Привет Пользователь");

String FIO = "Торяник Кирилл Александрович";
String group = "ИСП-243";
String data = "02.10.2026 - 18:48";

Console.WriteLine("Что вы хотите увидеть: 1 - ФИО, 2 - групп, 3 - показать дату, 4 - выход");

String x = Console.ReadLine();


if (x == "1") {Console.WriteLine(FIO);}
else if (x == "2") {Console.WriteLine(group);}
else if (x == "3") {Console.WriteLine(data);}
else {Console.WriteLine("");}