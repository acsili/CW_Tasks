using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

/*
 The aim of this kata is to create a class that represents an object that 
can be use to track the a count of specifc instances of a type.

For example if our type was a string and each instance of a string represented 
a the name of a fruit and we had the following unique fruit names; Apple, Orange, 
Pear and Apple, the class would encapsulate the following data:

Fruit	Count
Apple	2
Orange	1
Pear	1
In this kata all of our test examples will use the type of string and fruit names for the individual instances.

You can either use the supplied example tests to detect the API or use the API public interface definition below:

public class ItemCounter<T>
{
    public ItemCounter(T[] items) {}
    public int DistinctItems {}
    public int GetCount(T item) {}
    bool HasItem(T item) {}
}
For languages which handle generics the type must be a generic type
The constructor must take an array of the type
DistinctItems must return a count of all of the UNIQUE items the counter was constructed with
GetCount(T item) must return the count of the unique item specified.
HasItem(T item) must return true if the item exists in the counter
So using the example data of Apple, Orange, Pear and Apple;

DistinctItems will return 3
GetCount("Apple") will return 2, and
GetCount("Orange") will return 1
HasItem(T item) will return true for Apple and false for Turnip
Expected Exceptions Thrown
The constructor should throw an ArgumentNullException if the argument is null
GetCount(T) should throw an ArgumentNullException if the item passed is null
GetCount(T) should throw an InvalidOperationException if the item passed does not exist in the Counter.
 
*/
public class ItemCounter<T>
{
    private readonly Dictionary<T, int> _itemCounts = new Dictionary<T, int>();

    public int DistinctItems
    {
        get { return _itemCounts.Count; }
    }

    public int GetCount(T item)
    {
        if (item == null) throw new ArgumentNullException();

        foreach (var _item in _itemCounts)
        {
            if (EqualityComparer<T>.Default.Equals(item, _item.Key))
            {
                return _item.Value;
            }
        }
        throw new InvalidOperationException();
    }

    public bool HasItem(T item)
    {
        foreach (var _item in _itemCounts)
        {
            if (EqualityComparer<T>.Default.Equals(item, _item.Key))
            {
                return true;
            }
        }
        return false;
    }


    public ItemCounter(T[] items)
    {
        if (items == null) throw new ArgumentNullException();

        int count = 0;
        bool b = true;

        for (int i = 0; i < items.Length; i++)
        {
            for (int j = 0; j < items.Length; j++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], items[j])) count++;
            }

            foreach(var _item in _itemCounts)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], _item.Key))
                {
                    b = false; break;
                }
            }

            if (b) _itemCounts.Add(items[i], count);

            count = 0;
            b = true;
        }
    }
}

