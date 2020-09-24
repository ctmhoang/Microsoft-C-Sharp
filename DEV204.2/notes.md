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
