using System;
using System.ComponentModel;
using System.Diagnostics;


namespace Rocket.Wrappers.Abstract.Logging
{
    public interface IEventLogWrapper : ISupportInitialize, IDisposable
    {
        ISynchronizeInvoke SynchronizingObject { get; set; }
        bool EnableRaisingEvents { get; set; }
        int MinimumRetentionDays { get; }
        OverflowAction OverflowAction { get; }
        long MaximumKilobytes { get; set; }
        string MachineName { get; set; }
        string Log { get; set; }
        string LogDisplayName { get; }
        EventLogEntryCollection Entries { get; }
        string Source { get; set; }
        event EntryWrittenEventHandler EntryWritten;
        void Clear();
        void Close();
        void ModifyOverflowPolicy(OverflowAction action, int retentionDays);
        void RegisterDisplayName(string resourceFile, long resourceId);
        void WriteEntry(string message, EventLogEntryType type, int eventID, short category, byte[] rawData);
        void WriteEntry(string message, EventLogEntryType type, int eventID, short category);
        void WriteEntry(string message, EventLogEntryType type, int eventID);
        void WriteEntry(string message, EventLogEntryType type);
        void WriteEntry(string message);
        void WriteEvent(EventInstance instance, params object[] values);
        void WriteEvent(EventInstance instance, byte[] data, params object[] values);
    }
}