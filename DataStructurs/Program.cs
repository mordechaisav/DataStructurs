using DataStructurs;

LinkedList list = new LinkedList();
list.Add(5);
list.Add(6);
list.Add(7);
list.Add(6);
string a = list.Display();
Console.WriteLine(a);
//list.RemoveValue(6);
list.RemoveAllValue(6);
a = list.Display();
Console.WriteLine(a);