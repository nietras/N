N();
//var assemblies = from assembly in AppDomain.CurrentDomain.GetAssemblies()
//             from type in assembly.GetExportedTypes()
//             select type;

//var filtered = assemblies.GroupBy(a => a.Name.Length)
//    .OrderByDescending(x => x.Key);

//// Find the Longest and Shortest Types
//var longestTypes = filtered.First();
//var shortestTypes = filtered.Last();

//// Loop and print the Longest Type Names
//foreach (var nm in longestTypes)
//{
//    Console.WriteLine("Longest Type Name: {0} \nFullName: {1} \nTypeLength: {2}",
//        nm.Name, nm.FullName, nm.Name.Length);
//    Console.WriteLine("-------------------------------------------");
//}


//// Loop and print the Shortest Type Names
//foreach (var nm in shortestTypes)
//{
//    Console.WriteLine("Shortest Type Name: {0} \nFullName: {1} \nTypeLength: {2}",
//        nm.Name, nm.FullName, nm.Name.Length);
//    Console.WriteLine("-------------------------------------------");
//}

//Console.ReadLine();