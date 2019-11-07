using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises.Classes.Chapter10;

namespace Exercises.Tests.Chapter10
{
    public class GenreTests
    {
        [Fact]
        public void CanCreateGenreInstance()
        {
            var genre = new Genre(1, "Action");

            Assert.NotNull(genre);
            Assert.Equal(1, genre.Id);
            Assert.Equal("Action", genre.Name);
        }
    }
}
