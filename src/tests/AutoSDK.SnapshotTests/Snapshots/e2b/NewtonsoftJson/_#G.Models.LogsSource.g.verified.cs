//HintName: G.Models.LogsSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Source of the logs that should be returned
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LogsSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="persistent")]
        LogsSourcePersistent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="temporary")]
        LogsSourceTemporary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogsSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogsSource value)
        {
            return value switch
            {
                LogsSource.LogsSourcePersistent => "persistent",
                LogsSource.LogsSourceTemporary => "temporary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogsSource? ToEnum(string value)
        {
            return value switch
            {
                "persistent" => LogsSource.LogsSourcePersistent,
                "temporary" => LogsSource.LogsSourceTemporary,
                _ => null,
            };
        }
    }
}