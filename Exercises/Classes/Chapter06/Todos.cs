using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercises.Classes.Chapter06
{
    public class Todos
    {
        List<ToDo> todos = new List<ToDo>();

        public List<ToDo> Get() => todos;
        public void Add(string description) => todos.Add(new ToDo(description));
        public void Remove(ToDo todo) => todos.Remove(todo);
    }
}
