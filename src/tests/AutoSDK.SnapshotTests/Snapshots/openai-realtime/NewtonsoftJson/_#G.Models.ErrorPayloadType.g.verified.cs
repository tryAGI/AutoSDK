//HintName: G.Models.ErrorPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ErrorPayloadType
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
    public static class ErrorPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorPayloadType value)
        {
            return value switch
            {
                ErrorPayloadType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ErrorPayloadType.Error,
                _ => null,
            };
        }
    }
}