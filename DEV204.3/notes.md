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
