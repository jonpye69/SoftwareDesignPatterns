﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DesignPatterns.TransferObjectPattern
{
    public class StudentBusinessObject
    {
        //list is working as a database
        readonly List<StudentTransferObject> _students;

        public StudentBusinessObject()
        {
            _students = new List<StudentTransferObject>();
            var student1 = new StudentTransferObject("Robert", 0);
            var student2 = new StudentTransferObject("John", 1);
            _students.Add(student1);
            _students.Add(student2);
        }

        public StudentTransferObject StudentTransferObject
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    
        public void DeleteStudent(StudentTransferObject student)
        {
            _students.Remove(student);
            Trace.WriteLine("Student: Roll No " + student.Id + ", deleted from database" + Environment.NewLine);
        }

        //retrive list of students from the database
        public List<StudentTransferObject> GetAllStudents()
        {
            return _students;
        }

        public StudentTransferObject GetStudent(int id)
        {
            return _students[id];
        }

        public void UpdateStudent(StudentTransferObject student)
        {
            _students[student.Id].Name = student.Name;
            Trace.WriteLine("Student: Roll No " + student.Id + ", updated in the database" + Environment.NewLine);
        }
    }
}
