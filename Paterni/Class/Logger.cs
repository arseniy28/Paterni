using System;
using System.Collections.Generic;

public class Logger
{
    public enum Severity
    {
        NORMAL,
        NOTE,
        ERROR
    }

    // Синглтон
    private static Logger _instance;
    private List<LogEntry> _events; 
    private const int MaxEventCount = 10; 

    // Конструктор
    private Logger()
    {
        _events = new List<LogEntry>();
    }

    
    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    
    public void Log(Severity severity, string message)
    {
        var entry = new LogEntry(DateTime.Now, severity, message);

        
        _events.Add(entry);

        
        if (_events.Count > MaxEventCount)
        {
            _events.RemoveAt(0); 
        }
    }

    
    public void PrintLastEvents()
    {
        Console.WriteLine($"{"Time",-20} {"Severity",-10} Message");
        Console.WriteLine(new string('-', 50));

        foreach (var entry in _events)
        {
            Console.WriteLine($"{entry.Time,-20} {entry.EventSeverity,-10} {entry.Message}");
        }
    }
}
