//HintName: G.Models.SessionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionStatus value)
        {
            return value switch
            {
                SessionStatus.Completed => "COMPLETED",
                SessionStatus.Error => "ERROR",
                SessionStatus.Running => "RUNNING",
                SessionStatus.TimedOut => "TIMED_OUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => SessionStatus.Completed,
                "ERROR" => SessionStatus.Error,
                "RUNNING" => SessionStatus.Running,
                "TIMED_OUT" => SessionStatus.TimedOut,
                _ => null,
            };
        }
    }
}