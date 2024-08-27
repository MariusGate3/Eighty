if (args.Length == 0) {
    Console.WriteLine("Please provide a filename.");
    return 1;
}

try {
    string[] lines = File.ReadAllLines(args[0]);
    int maxLen = (int.TryParse(args[args.Length - 1], out int maxInput)) ? maxInput : 80;
    
    
    for (int i = 0; i < lines.Length; i++) {
        int len = lines[i].Length;
        if (len > 80) {
            Console.WriteLine("Line {0} is too long ({1} characters, maximum is {2})", i, len, maxLen);
        }
    }
    return 0;
}
catch {
    Console.WriteLine("Could not open file.");
    return 1;
}
