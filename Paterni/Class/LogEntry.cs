using System;

public class LogEntry
{
    public DateTime Time { get; set; } 
    public Logger.Severity EventSeverity { get; set; } 
    public string Message { get; set; } 

 
    public LogEntry(DateTime time, Logger.Severity severity, string message)
    {
        Time = time;
        EventSeverity = severity;
        Message = message;
    }
}
