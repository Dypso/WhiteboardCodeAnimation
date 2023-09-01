using System;
using System.Collections.Generic;

namespace WhiteboardCodeAnimation
{
    class Program
    {
        static List<SequenceData> sequences = new List<SequenceData>();
        
        static void Main(string[] args)
        {
            AddSequence("text", "This is an example text.");
            AddSequence("code", "public class MyClass { }");
            GenerateVideo();
        }
        
        public static void AddSequence(string type, object data)
        {
            sequences.Add(new SequenceData { Type = type, Data = data });
        }
        
        public static void GenerateVideo()
        {
            // Todo* Implement logic to generate video from sequences
        }
    }
    
    public class SequenceData
    {
        public string Type { get; set; }
        public object Data { get; set; }
    }
}