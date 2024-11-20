using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Ghi đè ToString để hiển thị thông tin học sinh
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách học sinh
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "An", Age = 16 },
                new Student { Id = 2, Name = "Binh", Age = 14 },
                new Student { Id = 3, Name = "Anh", Age = 17 },
                new Student { Id = 4, Name = "Cuong", Age = 19 },
                new Student { Id = 5, Name = "Lan", Age = 18 }
            };

            // a. In toàn bộ danh sách học sinh
            Console.WriteLine("Danh sach hoc sinh:");
            students.ForEach(s => Console.WriteLine(s));

            // b. Tìm và in các học sinh có tuổi từ 15 đến 18
            Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
            var ageRangeStudents = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            ageRangeStudents.ForEach(s => Console.WriteLine(s));

            // c. Tìm và in học sinh có tên bắt đầu bằng chữ "A"
            Console.WriteLine("\nHoc sinh co ten bat dau bang chu cai 'A':");
            var studentsWithNameA = students.Where(s => s.Name.StartsWith("A")).ToList();
            studentsWithNameA.ForEach(s => Console.WriteLine(s));

            // d. Tính tổng tuổi của tất cả học sinh
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

            // e. Tìm và in học sinh có tuổi lớn nhất
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine($"\nHoc sinh co tuoi lon nhat: {oldestStudent}");

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Age).ToList();
            sortedStudents.ForEach(s => Console.WriteLine(s));

            // Đợi người dùng nhấn phím để thoát
            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}

