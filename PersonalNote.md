HOW CAN CHAIN MULTIPLE CONSTRUCTOR
get set
public string Name{get,set};
can use property in contructor
readonly can use as field not varable in methods

return value

params like xarg in python and ... in java but need to declare array
base like super
override in signature after acccess modifier

Enum like C and Go aybe java

Need overwrite in child class need a `virtual` keyword in supper class

exntend like : C

as is key word

interface like java

call contructer in supper class use  `:`

use => in ref field to property

EXCEPTION IN CATCH DO NOT NEED TO GET A PARAM NAME

Collection can be access by []

Drive Dir Folder 

Delegate has same priority as class
if if above class can init with new 
or bind the method direct to it;

Delegate is distinguish from its return type and signature
`Access modifier Delegate Blah (int, int)`
To Sum up its just like function type in js

Delegate can concat and remove with + and - operator with eachother like array of function and foreach its called multicast
remove like a stack order
GetInvocationList().GetLength(0);

can  mapped to both static and instance methods and returns specific information from each.

Event -> add and remove delegate
same as Property 
has `add` and `set` method
candy sugar syntax `event Type Name` no not add method after curly braces

```
// Instantiate Del by using an anonymous method.
Del del3 = delegate(string name)
    { Console.WriteLine($"Notification received for: {name}"); };
```

```
// Instantiate Del by using a lambda expression.
Del del4 = name =>  { Console.WriteLine($"Notification received for: {name}"); };
```

# Mutiple thread in c#
using object Thread
has method start()
Piority Lwst BelowNorm Norm AboveNorm Hgest // ThreadPriority
Thread.sleep

## lock keyword in c# only using Object as lock so better set it to readonly

Container has Controls Collections like ele in container

MessageBox.show
Tab index
Location Point
Size
Text

UserControl

System.Data
.oredb
SqlConnection -> Connection String
SqlCommand .Text .CommandType .Execute Reader/NonQuery(Insert/Del/Up/Stored Procedure)(? lined effected)/Scalar(a unique value)/XmlReader

DataSet > DataTabel > DataRow/Column > DataCells
SqlDataAdapter (sel/ins/up/del)Command


ComboBox / ListBox / CheckedListBox/ DataGridView/ TreeView / .DataSource(Collections|Arrays|Datatables)
FormLoad Action
.Display/Value Mem
SelectedIndex/Text/Value/Item(Object);  

Only using to setup
DataGridView AutoGenerateColumns  but keep remember do it just before databinding
Add  -> DataPropertyName(Name in DB)
Hyberlink/button/checkout columns useColumnTextForButtonValue

CellClick
DataGridViewArgs.Cell.Column
DataSource Rows Cells DataMember // from gridview
RowIndex

SqlParameter addRange
SqlDbType -> MSSQL
DBType -> OREM DB


Config
connString -> add name? connectString
ConfigurationManager -> add Lib in ref

SqlCommand.Parameters.AddWithValu




WEB
AutoPostback
ID
runnat
OnEventChanged Properties
DataBind

ViewState + UI => Can postback
EnableViewState => do not have event
ASP
AutoGenerateColumn
HeaderSTyle?Footer
PagerStyle /Settings
Column > BoundField (DATA) / Button/ Checkbox / Command == button / HyberLink / ImageField/ StyleField > HeaderText / DataField/ Text
HyberLink > NavigateUrl # nhau / DataNavigateUrlFormatString="as.aspx?pid={0}&pas={1}" DataNavidateUrlFields="Var0, var1"
Request in c# > QueryString
Reponse i c# > Redirect


Session
GlobalApplicationClass
has Session Object
Repeater
ValidationControls
asp:TemplateField/Repeater > ItemTemplate >HTML tags 
= in complie time # in databind
listview
DataBinder.Eval?>DataContainer > DataItem

asp
label
Calender
DataTextField/ DataValueField
custom Validator


visible property
