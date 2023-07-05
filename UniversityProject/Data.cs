using UniversityProject.Models;

namespace UniversityProject
{
    public static class Data
    {
        public static List<Student> Students = new List<Student>
            {
                new Student{Id=1,Name="Kamil",Surname="Zeynalli",Group="p110"},
                new Student{Id=2,Name="Agakisi",Surname="Neymetulla",Group="p112"},
                new Student{Id=3,Name="Nigar",Surname="Memmedli",Group="p115"},
                new Student{Id=4,Name="Rovsen",Surname="Eliyev",Group="p118"}
            };
        public static List<Groups> Groups = new List<Groups> { new Groups { Id = 1, Name = "p110" }, new Groups { Id = 2, Name = "p112" }, new Groups { Id = 3, Name = "p115" }, new Groups { Id = 3, Name = "p118" } };
    }
}
