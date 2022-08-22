create db
scaffold statement

dotnet ef migrations add MyFristMigration

up ko comment kre down ko delete kre

dotnet ef database update

dotnet ef migrations add test-migratation

agr up or down me code na ho to database or classes same ha consistent

dotnet ef migrations remove (it will remove the last migration)

adding new column to table
1.adding property to that class
2.dotnet ef migrations AddedColumnToPrice
3.dotnet ef database update



//22 august 2022


 dependancy injection(inversion of control,Plug and play system)
agr backened pr sql use kr rahe ha aur nosql krna ha to us ke liye use hoga
1 interface bnate ha
loosely couple system bnane ke liye
isko plug and play system bhi kehte ha
object controller me kahi aur se araha ha


//employee management system as an example

implementation step1:

make folder interfaces and repository
make IEmployeeRepository to interface and Employeerepository to repository
make Employee class model id and name
make getallemployee function in employee

implement IEmployeeRepository into EmployeeRepository

tell which object should be injected at the midlleware