using Lab1._1;

var electricalAppliances = new ApplianceEnumerator(); //Коллекция электроприборов
electricalAppliances.Append(new Lamp()); //Лампа
electricalAppliances.Append(new Computer()); //Компьютер
electricalAppliances.Append(new Microwave()); //Микроволновка
electricalAppliances.Append(new Fridge()); //Холодильник

Console.WriteLine(electricalAppliances.ToString()); //Вывод списка электроприборов
Console.WriteLine($"Power consumption in home = {electricalAppliances.PowerDraw()}"); // Подсчет потребляемой энергии в доме
electricalAppliances.Sort(); //Сортировка по возрастанию
Console.WriteLine(electricalAppliances.ToString()); //
electricalAppliances.Sort(true); //Сортировка по убыванию
Console.WriteLine(electricalAppliances.ToString()); //
Console.WriteLine(electricalAppliances.Find(true, 100, "Lamp")?.ToString()); //Ищем приборы подходящие под критерии