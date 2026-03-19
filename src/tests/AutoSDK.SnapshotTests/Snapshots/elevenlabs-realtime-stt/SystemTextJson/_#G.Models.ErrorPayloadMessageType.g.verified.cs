//HintName: G.Models.ErrorPayloadMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be 'error'.
    /// </summary>
    public enum ErrorPayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorPayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorPayloadMessageType value)
        {
            return value switch
            {
                ErrorPayloadMessageType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorPayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ErrorPayloadMessageType.Error,
                _ => null,
            };
        }
    }
}