# Array
* Create 2 dimension array
```
// Create an array that is 10 long(rows) by 10 wide(columns)
int[ , ] arrayName = new int[10,10];
```
* Jagged arrays
```
 int[][] jaggedArray = new int[10][]; //must declare the size of first array
 jaggedArray[0] = new Type[5]; // Can specify different sizes.
 jaggedArray[1] = new Type[7];
 ...
 jaggedArray[9] = new Type[21];
```
