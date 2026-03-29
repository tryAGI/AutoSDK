//HintName: G.Models.AgentRequestDataStorageSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Granular setting to manage how Retell stores sensitive data (transcripts, recordings, logs, etc.).<br/>
    /// This replaces the deprecated `opt_out_sensitive_data_storage` field.<br/>
    /// - `everything`: Store all data including transcripts, recordings, and logs.<br/>
    /// - `everything_except_pii`: Store data without PII when PII is detected.<br/>
    /// - `basic_attributes_only`: Store only basic attributes; no transcripts/recordings/logs.<br/>
    /// If not set, default value of "everything" will apply.<br/>
    /// Example: everything
    /// </summary>
    public enum AgentRequestDataStorageSetting
    {
        /// <summary>
        /// Store only basic attributes; no transcripts/recordings/logs.
        /// </summary>
        BasicAttributesOnly,
        /// <summary>
        /// Store all data including transcripts, recordings, and logs.
        /// </summary>
        Everything,
        /// <summary>
        /// Store data without PII when PII is detected.
        /// </summary>
        EverythingExceptPii,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestDataStorageSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestDataStorageSetting value)
        {
            return value switch
            {
                AgentRequestDataStorageSetting.BasicAttributesOnly => "basic_attributes_only",
                AgentRequestDataStorageSetting.Everything => "everything",
                AgentRequestDataStorageSetting.EverythingExceptPii => "everything_except_pii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestDataStorageSetting? ToEnum(string value)
        {
            return value switch
            {
                "basic_attributes_only" => AgentRequestDataStorageSetting.BasicAttributesOnly,
                "everything" => AgentRequestDataStorageSetting.Everything,
                "everything_except_pii" => AgentRequestDataStorageSetting.EverythingExceptPii,
                _ => null,
            };
        }
    }
}