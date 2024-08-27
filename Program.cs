if (args.Length == 0) {
    Console.WriteLine("Please provide a filename.");
    return 1;
}

try {
    int maxLen = (int.TryParse(args[args.Length - 1], out int maxInput)) ? maxInput : 80;
    for (int p = 0; p < args.Length - 1; p++) {
        string[] lines = File.ReadAllLines(args[p]);        
        
        for (int i = 0; i < lines.Length; i++) {
            int len = lines[i].Length;
            if (len > maxLen) {
                Console.WriteLine("Line {0} is too long ({1} characters, maximum is {2}) in {3}", i + 1, len, maxLen, args[p]);
            }
        }
    }
    return 0;
}
catch {
    Console.WriteLine("Could not open file.");
    return 1;
}
