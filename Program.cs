if (args.Length == 0) {
    Console.WriteLine("Please provide a filename.");
    return 1;
}

try {
    string[] lines = File.ReadAllLines(args[0]);
    
    
    for (int i = 0; i < lines.Length; i++) {
        int len = lines[i].Length;
        if (len > 80) {
            Console.WriteLine("Line %d is too long (%d characters)", i, len);
        }
    }
    return 0;
}
catch {
    Console.WriteLine("Could not open file.");
    return 1;
}
