using System;
using Cse111Task1;

StudentList list = new StudentList();

void Show(string step)
{
    Console.Write(step + ": ");
    list.Print();
    Console.WriteLine($"   first={list.First?.Id.ToString() ?? "null"} " +
                      $"last={list.Last?.Id.ToString() ?? "null"} count={list.Count}");
}

Show("0 start");
list.AddFront(20); Show("1 AddFront(20)");
list.AddFront(10); Show("2 AddFront(10)");
list.AddEnd(30); Show("3 AddEnd(30)");
list.AddEnd(40); Show("4 AddEnd(40)");
list.Reverse(); Show("5 Reverse()");
list.Remove(20); Show("6 Remove(20)");