using Session_11;
using Session_11.UniClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    internal class DataHelper {

        public static List<Course> GetCourses() {

            List<Course> courses = new List<Course>();
            Guid id = Guid.Parse("{3F2B565A-83CD-4D3B-9793-2BD6645942BD}");

            Course courseMath = new Course() {
                Name = "Mathematics I",
                Semester = Course.SemesterEnum.Winter,
                ID = id
            };
            courses.Add(courseMath);

            id = Guid.Parse("{1C21DF3F-F34B-44B0-B186-C002E6BD4C7E}");
            Course coursePhys = new Course() {

                Name = "Physics",
                Semester = Course.SemesterEnum.Winter,
                ID = id
            };
            courses.Add(coursePhys);

            id = Guid.Parse("{EB26C45D-B18D-4149-B3E4-4FC7D21D454C}");
            Course courseProg = new Course() {
                Name = " Programming I",
                Semester = Course.SemesterEnum.Spring,
                ID = id
            };
            courses.Add(courseProg);

            return courses;
        }

        public static List<University> GetUniversities() {


            Guid id = Guid.Parse("{72F9974A-370C-4FCE-AD99-9A73FC089E60}");

            University uni1 = new University(id) {
                Name = "NTUA",
                Region = "Athens"
            };

            id = Guid.Parse("{D3DB7E60-9BDA-41F3-9FDE-A39C77FE03A9}");
            University uni2 = new University(id) {
                Name = "UNIPI",
                Region = "Peiraeus"
            };

            University uni3 = new University(Guid.Empty) {
            };

            List<University> universities = new List<University>() { uni1, uni2, uni3 };
            return universities;
        }
    }
}
