# Property in Cs
```
// The following statements define a property with a private field.
   private string _location;
   public string Location
   {
      get
      {
         return _location;
      }
      set
      {
         if (value != null) 
            _location = value;
      }
   }
   // The following statements define properties.
   public string Make {get; set;}
   public string Model {get; set;}
```
* Properties would be backed by private member variables with lower case.

* A get property accessor is used to return the property value

* A set accessor is used to assign a new value. (Omitting this property makes it read only)

* A value keyword is used to define the "value" being assigned by the set accessor.

* Properties that do not implement a set accessor are read only.

For simple properties that require no custom accessor code, consider the option of using auto-implemented properties.
# Partial Classes
* Split the definition of the class across multiple source files. Then compile application, all of the parts are combined into a single file.
* Partial class with the same name
* Note: split structs and interfaces across multiple source files as well.

# Struct value type class ref type

# Type inference (`var` keyword)

# Event 
```
   // The following statement defines an event. The delegate definition is not shown.
   public event OutOfBeansHandler OutOfBeans;
```
# Static Classes
`public static class Conversions`
* Any members within the class must also use the static keyword

# Instantiating an object of Car() Class by using Object initializer. It only work if had a default contructor
`var car1 = new Car {Color = "White", Year = 2010, Mileage = 11000};`
# Anonymous class
`var anAnonymousObject = new { Name = "Tom", Age = 65 };`
* anonymous classes can contain only public fields
* the fields must all be initialized
* fields cannot be static
* you cannot define any methods for them
### region name and endregion collapse with name
### Interface has 2 access modifier `public` and `internal`
### Inherit use colon :
# Indexer
`string this[int index] { get; set; }`
### Event
`event EventHandler OnSoldOut;`


## Sealed like final in java

### struct cannot be extend

##  Explicit implementation of interface:
`InterfaceName.indentifier`
## Implicit cast
`IBeverage beverage = coffee1;`

## Down cast
```
// Casting an Interface Type to a Derived Class Type
Coffee coffee3 = beverage as Coffee;
// OR
Coffee coffee4 = (Coffee)beverage;
Implementing Multiple Interfaces
```
### [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable?view=netcore-3.1)
* enable the .NET runtime to dispose of your class correctly.
# My personal Notes
```
get set
public string Name{get,set};
can use property in contructor
readonly can use as field not varable in methods

return value

params like xarg in python and ... in java but need to declare array
base like super
override in signature after acccess modifier when super method is virtual

Enum like C and Go maybe java

Need overwrite in child class need a `virtual` keyword in supper class

exntend like : C

as is key word

interface like java

call contructer in supper class use  `:`

use => in ref field to property
```
