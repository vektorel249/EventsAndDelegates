using Vektorel.Events.Models;
using Vektorel.Family.Enums;
using Vektorel.Family.Models;

namespace Vektorel.Events
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Sonsuzluk
        int a = 0;
        public void A()
        {
            //if (a == 5)
            //{
            //    return;
            //}
            //a++;
            A();
        }
        #endregion
        private void FrmMain_Load(object sender, EventArgs e)
        {
            var course = new Course(".NET Yazýlým", 10);

            var s1 = new Student { FirstName = "Uður", LastName = "Dirgen" };

            s1.OnCourseAssigned += OnCourseAssigned_NotifyExternalServices;
            s1.OnCourseAssigned += OnCourseAssigned_GetPayment;

            var s2 = new Student { FirstName = "Arda", LastName = "Eflatun" };
            s2.OnCourseAssigned += OnCourseAssigned_SendSMS;

            var s3 = new Student { FirstName = "Mücahit", LastName = "Bak" };
            s3.OnCourseAssigned += OnCourseAssigned_SendSMS;
            s3.OnCourseAssigned += OnCourseAssigned_NotifyExternalServices;
            s3.OnCourseAssigned += OnCourseAssigned_GetPayment;

            var s4 = new Student { FirstName = "Gürkan", LastName = "Yýldýz" };
            s4.OnCourseAssigned += OnCourseAssigned_SendMobileNotification;

            course.AddStudent(s1);
            course.AddStudent(s2);

            //s1.OnCourseAssigned -= OnCourseAssigned_NotifyExternalServices;
            //s1.OnCourseAssigned -= OnCourseAssigned_GetPayment;
        }

        private void OnCourseAssigned_SendMobileNotification(Course course)
        {
        }

        private void OnCourseAssigned_SendSMS(Course course)
        {

        }

        private void OnCourseAssigned_NotifyExternalServices(Course course)
        {

        }

        private void OnCourseAssigned_GetPayment(Course course)
        {

        }

        private void btnCreateFamily_Click(object sender, EventArgs e)
        {
            var root = new RootPerson() { FullName = "Adem" };

            var c1 = new FamilyPerson { FullName = "Ahmet", Gender = Gender.Male };
            var c2 = new FamilyPerson { FullName = "Mehmet", Gender = Gender.Male };
            c1.SetParents(root, null);
            c2.SetParents(root, null);

            var c11  = new FamilyPerson { FullName = "Arif", Gender = Gender.Male };
            var c12  = new FamilyPerson { FullName = "Asým", Gender = Gender.Male };
            var c13  = new FamilyPerson { FullName = "Arda", Gender = Gender.Male };

            var c21  = new FamilyPerson { FullName = "Mustafa", Gender = Gender.Male };
            var c22  = new FamilyPerson { FullName = "Muhammet", Gender = Gender.Male };

            c11.SetParents(c1, null);
            c12.SetParents(c1, null);
            c13.SetParents(c1, null);

            c21.SetParents(c2, null);
            c22.SetParents(c2, null);

            c11.AddSibling(c12);
            c12.AddSibling(c13);
            c11.AddSibling(c13);

            c21.AddSibling(c22);
        }


        // DDD: Domain Driven Design
        // EDD: Event Driven Design *
    }
}
