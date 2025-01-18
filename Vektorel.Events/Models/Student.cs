using Vektorel.Events.Actions;

namespace Vektorel.Events.Models;

internal class Student
{
    public Student()
    {
        Lectures = new List<Lecture>();
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Lecture> Lectures { get; }
    public Course Course { get; set; }

    public event CourseAssigned OnCourseAssigned;

    public void SetCourse(Course course)
    {
        Course = course; // 30 satırlık tanım kodu

        //if (OnCourseAssigned != null)
        //{
        //    OnCourseAssigned.Invoke(course);
        //}

        OnCourseAssigned?.Invoke(course);
    }
}
