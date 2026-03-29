//HintName: G.Models.SessionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the current status of the session. Can be either 'active' or 'completed'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
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
                SessionStatus.Active => "active",
                SessionStatus.Completed => "completed",
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
                "active" => SessionStatus.Active,
                "completed" => SessionStatus.Completed,
                _ => null,
            };
        }
    }
}