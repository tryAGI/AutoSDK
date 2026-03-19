//HintName: G.Models.ResponseCancelPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseCancelPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.cancel")]
        ResponseCancel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCancelPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCancelPayloadType value)
        {
            return value switch
            {
                ResponseCancelPayloadType.ResponseCancel => "response.cancel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCancelPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.cancel" => ResponseCancelPayloadType.ResponseCancel,
                _ => null,
            };
        }
    }
}