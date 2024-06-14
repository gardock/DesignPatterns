using Flyweight;

UsersList list = new UsersList();
(string, string, string)[] types = new (string, string, string)[5]
    {
        ("test1","red", RandomString(250)),
        ("test2","green", RandomString(1250)),
        ("test3","green", RandomString(1250)),
        ("test4","red", RandomString(5250)),
        ("test5","green", RandomString(850))
    };
int timesToAddType = 100000;

foreach (var item in types)
{
    for (int i = 0; i < timesToAddType; i++)
    {
        //list.Add(RandomString(5), item.Item1, item.Item3, item.Item2);
        list.StandardAdd(RandomString(5), item.Item1, item.Item3, item.Item2);
    }
}


Console.WriteLine($"Lsita ma {list.GetCount()} elementów.");
Console.ReadKey();


string RandomString(int length)
{
    Random random = new Random();
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
}