using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises.Classes.Chapter10;

namespace Exercises.Tests.Chapter10
{
    public class FilmTests
    {
        [Fact]
        public void CanCreateGenreInstanceWithGenre()
        {
            var genre = new Genre(1, "Action");
            var film = new Film(1, "The Title", 1920, genre);

            Assert.NotNull(film);
            Assert.Equal(1, film.Id);
            Assert.Equal("The Title", film.Title);
            Assert.Equal(1920, film.Year);
            Assert.NotEmpty(film.Genres);
        }
        [Fact]
        public void CanCreateGenreInstanceWithoutGenre()
        {
            var film = new Film(1, "The Title", 1920);

            Assert.NotNull(film);
            Assert.Equal(1, film.Id);
            Assert.Equal("The Title", film.Title);
            Assert.Equal(1920, film.Year);
            Assert.Empty(film.Genres);
        }
    }
}
