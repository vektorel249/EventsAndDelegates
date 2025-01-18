namespace Vektorel.Events.Models;

internal class Course
{
    private int studentCount;
    private readonly List<Student> students;

    public Course(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
        students = new List<Student>();
    }
    public string Name { get; }
    public int Capacity { get; }
    public int StudentCount { get { return studentCount; } }

    public bool AddStudent(Student student) // BONUS KONU ANLAT
    {
        if (Capacity == studentCount)
        {
            return false;
        }
        //if öğrenci daha önce eklendiyse false dön
        students.Add(student);

        #region Yapılan İş Aynı
        student.SetCourse(this);
        //student.Course = this; // 30 satırlık tanım kodu 
        #endregion
        studentCount++;
        return true;
    }
}
