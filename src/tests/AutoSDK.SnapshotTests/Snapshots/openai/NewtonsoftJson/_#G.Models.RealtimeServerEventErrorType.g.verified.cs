//HintName: G.Models.RealtimeServerEventErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `error`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventErrorType value)
        {
            return value switch
            {
                RealtimeServerEventErrorType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventErrorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => RealtimeServerEventErrorType.Error,
                _ => null,
            };
        }
    }
}