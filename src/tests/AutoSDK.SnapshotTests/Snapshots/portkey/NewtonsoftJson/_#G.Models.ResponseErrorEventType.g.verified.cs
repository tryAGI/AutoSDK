//HintName: G.Models.ResponseErrorEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `error`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseErrorEventType
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
    public static class ResponseErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseErrorEventType value)
        {
            return value switch
            {
                ResponseErrorEventType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ResponseErrorEventType.Error,
                _ => null,
            };
        }
    }
}