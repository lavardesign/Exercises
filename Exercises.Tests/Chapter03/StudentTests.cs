using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises.Classes.Chapter03;

namespace Exercises.Tests.Chapter03
{
    public class StudentTests
    {
        [Fact]
        public void CanCreateStudentDefaultInstance()
        {
            var student = new Student();

            Assert.NotNull(student);
        }

        [Fact]
        public void CanCreateStudentInstanceWithParameters()
        {
            var student = new Student("John", "Doe", 23);

            Assert.NotNull(student);
            Assert.Equal(23, student.age);
            Assert.Equal("John Doe", student.FullName);
        }
    }
}
