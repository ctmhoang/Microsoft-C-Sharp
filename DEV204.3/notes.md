# Array
* Create 2 dimension array
```
// Create an array that is 10 long(rows) by 10 wide(columns)
int[ , ] arrayName = new int[10,10];
char[,] multiArray = new char[3, 2] { { 'a', 'b' }, {'c', 'd' }, {'e', 'f' }};

```
* Jagged arrays
```
 int[][] jaggedArray = new int[10][]; //must declare the size of first array
 jaggedArray[0] = new Type[5]; // Can specify different sizes.
 jaggedArray[1] = new Type[7];
 ...
 jaggedArray[9] = new Type[21];
```

# Enum
* Create
```
enum Indentfier {values,... };
```
* Define start value
```
enum Day { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

```
* Enums support intrinsic data types and can be any one of the following: (how much storage will be allocated for each enumerator in the enum) (default is int)
 *  (s)(byte)
 * (u)(short/int/long)
* Change default type of enum
```
enum Day : short { Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
```
* Need cast to convert to number type
* Using name and value interchangeably
```
// Set an enum variable by name.
Day favoriteDay = Day.Friday;
// Set an enum variable by value.
Day favoriteDay = (Day)4;
```
# Struct
* lightweight data structures that represent related pieces of information as a single item
* Declare
```
//Declaring a Struct
public struct Coffee
{
public int Strength;
public string Bean;
public string CountryOfOrigin;
// Other methods, fields, properties, and events.
}
```
* Can have olnly 3 access modifier
 * public
 * internal (default)
 * private (can be using in nested struct)
* structs are intended to be lightweight therefore if you find yourself adding multiple methods, constructors, and events, you should consider using a class instead
* create an instance of a struct, you use the new keyword
* cannot add a default constructor to a struct because it is created by the compiler
* Indexer
```
 public string this[int index]
    {
        get { return this.beverages[index]; }
        set { this.beverages[index] = value; }
    }
    // Enable client code to determine the size of the collection.
    public int Length
    {
        get { return beverages.Length; }
    }
```
# Hashtable
* Formular hash func in hastable
`Hk(key) = [GetHash(key) + k * (1 + (((GetHash(key) >> 5) + 1) % (hashsize – 1)))] % hashsize`
* the expected number of probes needed when a collision occurs is at most 1 / (1 – lf), where lf is the load factor

# Standard collection
| Class	| Description |
| ----- | ----------- |
| ArrayList | The ArrayList is a general-purpose list that stores a linear collection of objects. The ArrayList includes methods and properties that enable you to add items, remove items, count the number of items in the collection, and sort the collection. |
| BitArray |	The BitArray is a list class that represents a collection of bits as Boolean values. The BitArray is most commonly used for bitwise operations and Boolean arithmetic, and includes methods to perform common Boolean operations such as AND, NOT, and XOR. |
| Hashtable |	The Hashtable class is a general-purpose dictionary class that stores a collection of key/value pairs. The Hashtable includes methods and properties that enable you to retrieve items by key, add items, remove items, and check for particular keys and values within the collection. |
| Queue |	The Queue class is a first in, first out collection of objects. The Queue includes methods to add objects to the back of the queue (Enqueue) and retrieve objects from the front of the queue (Dequeue). |
| SortedList |	The SortedList class stores a collection of key/value pairs that are sorted by key. In addition to the functionality provided by the Hashtable class, the SortedList enables you to retrieve items either by key or by index. |
| Stack |	The Stack class is a first in, last out or last in, first out (LIFO) collection of objects. The Stack includes methods to view the top item in the collection without removing it (Peek), add an item to the top of the stack (Push), and remove and return the item at the top of the stack (Pop). |
# Specialized Collections
| Class |	Description |
| ----- | ----------- |
| ListDictionary |	The ListDictionary is a dictionary class that is optimized for small collections. As a general rule, if your collection includes 10 items or fewer, use a ListDictionary. If your collection is larger, use a Hashtable. |
| HybridDictionary |	The HybridDictionary is a dictionary class that you can use when you cannot estimate the size of the collection. The HybridDictionary uses a ListDictionary implementation when the collection size is small, and switches to a Hashtable implementation as the collection size grows larger. |
| OrderedDictionary |	The OrderedDictionary is an indexed dictionary class that enables you to retrieve items by key or by index. Note that unlike the SortedList class, items in an OrderedDictionary are not sorted by key. |
| NameValueCollection |	The NameValueCollection is an indexed dictionary class in which both the key and the value are strings. The NameValueCollection will throw an error if you attempt to set a key or a value to anything other than a string. You can retrieve items by key or by index. |
| StringCollection |	The StringCollection is a list class in which every item in the collection is a string. Use this class when you want to store a simple, linear collection of strings.. |
|StringDictionary |	The StringDictionary is a dictionary class in which both the key and the value are strings. Unlike the NameValueCollection class, you cannot retrieve items from a StringDictionary by index. |
|BitVector32 |	The BitVector32 is a struct that can represent a 32-bit value as both a bit array and an integer value. Unlike the BitArray class, which can expand indefinitely, the BitVector32 struct is a fixed 32-bit size. As a result, the BitVector32 is more efficient than the BitArray for small values. You can divide a BitVector32 instance into sections to efficiently store multiple values. |
