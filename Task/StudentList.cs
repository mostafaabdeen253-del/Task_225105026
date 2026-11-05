// Name: Mostafa Ahmed Atef
// Student ID: 225105026

using System;
using System.Text;

namespace Cse111Task1;

public class StudentList
{
    public Student? First;
    public Student? Last;
    public int Count;

    
    public void AddFront(int id)
    {
        Student node = new Student(id);
        node.Next = First;
        First = node;
        if (Last == null)     
            Last = node;
        Count++;
    }

   
    public void AddEnd(int id)
    {
        Student node = new Student(id);
        if (First == null)    
        {
            First = node;
            Last = node;
        }
        else
        {
            Last!.Next = node;
            Last = node;
        }
        Count++;
    }

   
    public bool Remove(int id)
    {
        Student? prev = null;
        Student? curr = First;

        while (curr != null && curr.Id != id)
        {
            prev = curr;
            curr = curr.Next;
        }

        if (curr == null)      
            return false;

        if (prev == null)     
            First = curr.Next;
        else
            prev.Next = curr.Next;

        if (curr == Last)     
            Last = prev;       

        curr.Next = null;
        Count--;
        return true;
    }

   
    public void Reverse()
    {
        Student? prev = null;
        Student? curr = First;
        Last = First;       

        while (curr != null)
        {
            Student? next = curr.Next; 
            curr.Next = prev;
            prev = curr;
            curr = next;
        }

        First = prev;
    }


    public void Print()
    {
        StringBuilder sb = new StringBuilder();
        Student? curr = First;
        while (curr != null)
        {
            if (sb.Length > 0) sb.Append(' ');
            sb.Append(curr.Id);
            curr = curr.Next;
        }
        Console.WriteLine(sb.ToString());
    }
}