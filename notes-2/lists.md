List = data structure that represents a list of objects that can be accessed by index.
Similar to array, but can dynamically increase/decrease in size using System.Collections.Generic;

List<String> food = new List<String>();
food.Add("Pizza")

Another Usefull methods:

food.Remove("name");
food.Insert(0, "sushi");
food.Count;
food.IndexOf(name);
food.LastIndexOf(name);
food.Contains(name);
food.Sort();
food.Reverse();
food.Clear();
String[] foodArray = food.ToArray();
