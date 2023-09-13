﻿using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp.Services
{
    public class MenuService
    {
        private static ClassroomService classroomService = new();

        public static void MenuAddClassroom()
        {
            try
            {
                Console.WriteLine("Enter classroom's name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter classroom's subject:");
                string subject = Console.ReadLine()!;

                int classRoomId = classroomService.AddClassroom(name, subject);

                Console.WriteLine($"Classroom with ID:{classRoomId} was created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuDeleteClassroom()
        {
            try
            {
                Console.WriteLine("Enter classroom's id:");
                int id = int.Parse(Console.ReadLine()!);

                classroomService.DeleteClassroom(id);

                Console.WriteLine($"Classroom with ID:{id} was deleted!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuShowClassrooms()
        {
            var table = new ConsoleTable("ID", "Name", "Subject");

            foreach (var classroom in classroomService.ShowClassrooms())
            {
                table.AddRow(classroom.Id, classroom.Name, classroom.Subject);
            }

            table.Write();
        }
        public static void MenuUpdateClassroom()
        {
            try
            {
                Console.WriteLine("Enter classroom's id:");
                int id = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter classroom's name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter classroom's subject:");
                string subject = Console.ReadLine()!;

                var updateClassroom = classroomService.UpdateClassroom(id, name, subject);

                Console.WriteLine($"Classroom with ID:{id} was updated!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuAddStudent()
        {
            try
            {
                Console.WriteLine("Enter student's name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter student's surname:");
                string surname = Console.ReadLine()!;

                Console.WriteLine("Enter student's birthday (MM/dd/yyyy):");
                DateOnly birthday = DateOnly.Parse(Console.ReadLine()!);

                int studentId = classroomService.AddStudent(name, surname, birthday);

                Console.WriteLine($"Student with ID:{studentId} was created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuDeleteStudent()
        {
            try
            {
                Console.WriteLine("Enter students's id:");
                int id = int.Parse(Console.ReadLine()!);

                classroomService.DeleteStudent(id);

                Console.WriteLine($"Student with ID:{id} was deleted!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void MenuShowStudents()
        {
            var table = new ConsoleTable("ID", "Name", "Surname", "Birthday");

            foreach (var student in classroomService.ShowStudents())
            {
                table.AddRow(student.Id, student.Name, student.Surname, student.Birthday);
            }

            table.Write();
        }

        public static void MenuUpdateStudent()
        {
            try
            {
                Console.WriteLine("Enter student's id:");
                int id = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter student's name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter student's surname:");
                string surname = Console.ReadLine()!;

                Console.WriteLine("Enter student's birthday:");
                DateOnly birthday = DateOnly.Parse(Console.ReadLine()!);

                var updateClassroom = classroomService.UpdateStudent(id, name, surname,birthday);

                Console.WriteLine($"Student with ID:{id} was updated!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
