﻿using System.Collections.Generic;
using System.IO;

namespace Program
{
    public class Reader
    {
        public static IEnumerable<string> ReadRepositoreis(string fileName)
        {
            var repositories = new List<string>(File.ReadAllLines(fileName, System.Text.Encoding.Unicode));
            foreach (var repository in repositories)
            {
                yield return repository;
            }
        }
    }
}