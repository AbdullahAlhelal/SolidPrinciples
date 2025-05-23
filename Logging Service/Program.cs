﻿using System;
using System.Transactions;

public class LoggingService
{
    public enum enLoggingType { ToFile, ToEventLog, ToDatabase }

    public void Log(string message, enLoggingType LoggingType)
    {

        if (LoggingType == enLoggingType.ToFile)
        {
            LogToFile(message);
        }
        else if (LoggingType == enLoggingType.ToEventLog)
        {
            LogToEventLog ( message);
        }
        else if (LoggingType == enLoggingType.ToDatabase)
        {
            LogToDatabse( message);
        }
    }

    // Method to log to file
    private void LogToFile(string message)
    {
        Console.WriteLine($"\nLog to file: {message}");
    }

    // Method to log to EventLog
    private void LogToEventLog(string message)
    {
        Console.WriteLine($"\nLog to Event Log: {message}");
    }

    // Method to log to file
    private void LogToDatabse(string message)
    {
        Console.WriteLine($"\nLog to Database: {message}");
    }

}

class Program
{
    static void Main()
    {
        // Create an instance of the LoggingService
        LoggingService LoggingService = new LoggingService();

        // Log to File
        LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToFile);

        // Log to Event Log
        LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToEventLog);

        // Log to Database
        LoggingService.Log("Error Occured line xxx.", LoggingService.enLoggingType.ToDatabase);

        Console.ReadKey();

    }
}
