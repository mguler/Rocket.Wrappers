using Rocket.Wrappers.Abstract.Logging;
using System.ComponentModel;
using System.Diagnostics;

namespace Rocket.Wrappers.Impl.Logging
{
    public class EventLogWrapper : IEventLogWrapper
    {
        private readonly EventLog _eventLog;
        public ISynchronizeInvoke SynchronizingObject { get => _eventLog.SynchronizingObject; set => _eventLog.SynchronizingObject = value; }
        public bool EnableRaisingEvents { get => _eventLog.EnableRaisingEvents; set => _eventLog.EnableRaisingEvents = value; }
        public int MinimumRetentionDays => _eventLog.MinimumRetentionDays;
        public OverflowAction OverflowAction => _eventLog.OverflowAction;
        public long MaximumKilobytes { get => _eventLog.MaximumKilobytes; set => _eventLog.MaximumKilobytes=value; }
        public string MachineName { get => _eventLog.MachineName; set => _eventLog.MachineName = value; }
        public string Log { get => _eventLog.Log; set => _eventLog.Log = value; }
        public string LogDisplayName => _eventLog.LogDisplayName;
        public EventLogEntryCollection Entries => _eventLog.Entries;
        public string Source { get => _eventLog.Source; set => _eventLog.Source = value; }
     
        public event EntryWrittenEventHandler EntryWritten { add => _eventLog.EntryWritten += value; remove => _eventLog.EntryWritten -= value;  }
      
        public void BeginInit() => _eventLog.BeginInit();
        public void Clear() => _eventLog.Clear();
        public void Close() => _eventLog.Close();
        public void Dispose() => _eventLog.Dispose();
        public void EndInit() => _eventLog.EndInit();
        public void ModifyOverflowPolicy(OverflowAction action, int retentionDays) => _eventLog.ModifyOverflowPolicy(action, retentionDays);
        public void RegisterDisplayName(string resourceFile, long resourceId) => _eventLog.RegisterDisplayName(resourceFile, resourceId);
        public void WriteEntry(string message, EventLogEntryType type, int eventID, short category, byte[] rawData) => _eventLog.WriteEntry(message, type, eventID, category, rawData);
        public void WriteEntry(string message, EventLogEntryType type, int eventID, short category) => _eventLog.WriteEntry(message, type, eventID, category);
        public void WriteEntry(string message, EventLogEntryType type, int eventID) => _eventLog.WriteEntry(message, type, eventID);
        public void WriteEntry(string message, EventLogEntryType type) => _eventLog.WriteEntry(message, type);
        public void WriteEntry(string message) => _eventLog.WriteEntry(message);
        public void WriteEvent(EventInstance instance, params object[] values) => _eventLog.WriteEvent(instance, values);
        public void WriteEvent(EventInstance instance, byte[] data, params object[] values) => _eventLog.WriteEvent(instance, data, values);
 
        public EventLogWrapper(EventLog eventLog)
        {
            _eventLog = eventLog;
        }
        public EventLogWrapper()
        {
            _eventLog = new EventLog();
        }
        public EventLogWrapper(string logName) 
        {
            _eventLog = new EventLog(logName);
        }
        public EventLogWrapper(string logName, string machineName)
        {
            _eventLog = new EventLog(logName, machineName);
        }
        public EventLogWrapper(string logName, string machineName, string source)
        {
            _eventLog = new EventLog(logName, machineName, source);
        }
    }
}
