using CustomGenericCollection.Models;

Custom<string> custom = new Custom<string>();
custom.Add("Cosqun");
custom.Add("Valeh");
custom.Add("Arif");
custom.Add("Semed");
custom.Add("Arif1");

//Console.WriteLine(custom.Count);
//Console.WriteLine( custom.Contains("Cosqun") ); 
//custom.Clear();
//Console.WriteLine(custom.Count);
custom.Remove("Arif");
 Console.WriteLine(custom.Count);