var studentlist = new List<User>();
var teacherlist = new List<User>();
for ( int i=0; i<2; i++ ){

    var student = new Student();
    var teacher = new Teacher();
    int userId = Convert.ToInt32(System.Console.ReadLine());
    string username = System.Console.ReadLine();
    string password = System.Console.ReadLine();
    var st = new Student(userId, username, password);
    var te = new Teacher(userId, username, password);
    studentlist.Add(st);
    teacherlist.Add(te);
}
foreach (var item in studentlist)
{
    item.GetUserInfo();
}
foreach (var item in teacherlist)
{
    item.GetUserInfo();
}
