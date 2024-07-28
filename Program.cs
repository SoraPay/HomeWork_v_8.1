//Доработайте приложение генеалогического дерева таким образом чтобы программа выводила на экран близких родственников (жену/мужа).
//Продумайте способ более красивого вывода с использованием горизонтальных и вертикальных черточек.

using HomeWork1;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {


        FamilyMebers[] wifeGrandMother = { new FamilyMebers() { FullName = "Ольга", Age = 62 }, new FamilyMebers() { FullName = "Лилия", Age = 55 } };
        FamilyMebers[] wifeGrandFather = { new FamilyMebers() { FullName = "Артур", Age = 54, Wife = wifeGrandMother[0] }, new FamilyMebers() { FullName = "Петр", Age = 72, Wife = wifeGrandMother[1] } };
        wifeGrandMother[0].Husband = wifeGrandFather[0];
        wifeGrandMother[1].Husband = wifeGrandFather[1];
        FamilyMebers wifeMother = new FamilyMebers() { FullName = "Ангелина", Age = 45, Mother = wifeGrandMother[0], Father = wifeGrandFather[0] };
        FamilyMebers wifeFather = new FamilyMebers() { FullName = "Сергей", Age = 55, Mother = wifeGrandMother[1], Father = wifeGrandFather[1], Wife = wifeMother };
        wifeMother.Husband = wifeFather;
        FamilyMebers wife = new FamilyMebers() { FullName = "Василиса", Age = 19, Mother = wifeMother, Father = wifeFather };


        FamilyMebers[] grandMother = { new FamilyMebers() { FullName = "Светлана", Age = 60 }, new FamilyMebers() { FullName = "Тасия", Age = 65 } };
        FamilyMebers[] grandFather = { new FamilyMebers() { FullName = "Арут", Age = 50, Wife = grandMother[0] }, new FamilyMebers() { FullName = "Михаил", Age = 55, Wife = grandMother[1] } };
        grandMother[0].Husband = grandFather[0];
        grandMother[1].Husband = grandFather[1];
        FamilyMebers mother = new FamilyMebers() { FullName = "Юлия", Age = 40, Mother = grandMother[0], Father = grandFather[0] };
        FamilyMebers father = new FamilyMebers() { FullName = "Василий", Age = 45, Mother = grandMother[1], Father = grandFather[1], Wife = mother };
        mother.Husband = father;

        FamilyMebers familyMebers = new FamilyMebers()
        {
            FullName = "Игорь Васильевич Тетерев",
            Age = 20,
            Mother = mother,
            Father = father,
            Wife = wife
        };

        wife.Husband = familyMebers;


        PrintAllFullName(familyMebers);


    }

    static public void PrintAllFullName(FamilyMebers person)
    {
        Console.Write("Бабушки: ");
        foreach (var item in person.Grandmother())
            if (item != null)
                Console.Write(item.FullName + " | ");
        Console.WriteLine();

        Console.Write("Дедушки: ");
        foreach (var item in person.Grandfather())
            if (item != null)
                Console.Write(item.FullName + " | ");
        Console.WriteLine();

        Console.WriteLine("Мама: " + person.Mother?.FullName);
        Console.WriteLine("Папа: " + person.Father?.FullName);
        Console.WriteLine("Вторая половинка: " + person.Wife?.FullName + person.Husband?.FullName);
    }
}






