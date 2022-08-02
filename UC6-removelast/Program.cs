using UC6_removelast;

Console.WriteLine("day14 UC5 - Linkedlist list problem");
Linkedlist list = new Linkedlist();
//list.Add(56);
//list.(30); 
//list.Infront();
list.Removelast();
list.RemoveFirst();
list.Add(70);
list.Infront(30);
list.InMiddle(25);
list.Add(25);
//list.Add(30);

list.Infront(56);
list.Display();