using System;

namespace StudentManagement
{
    class Student
    {
        private string mssv;
        private string name;
        private DateTime dateOfBirth;
        private string address;
        private long phoneNumer;
        private int schoolYear;
        private string typeDegree;

        public string Mssv { get => mssv; set => mssv = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Address { get => address; set => address = value; }
        public long PhoneNumer { get => phoneNumer; set => phoneNumer = value; }
        public int SchoolYear { get => schoolYear; set => schoolYear = value; }
        public string TypeDegree { get => typeDegree; set => typeDegree = value; }
    }
}
