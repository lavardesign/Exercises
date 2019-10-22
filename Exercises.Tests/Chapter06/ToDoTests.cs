using Exercises.Classes.Chapter06;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Exercises.Tests.Chapter06
{
    public class ToDoTests
    {
        [Fact]
        public void CanCreateToDoInstance()
        {
            var todo = new ToDo("Todo 1");

            Assert.NotNull(todo);
        }
    }
}
