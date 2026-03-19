//HintName: G.Models.ResponseContentPartDonePayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseContentPartDonePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.content_part.done")]
        ResponseContentPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseContentPartDonePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseContentPartDonePayloadType value)
        {
            return value switch
            {
                ResponseContentPartDonePayloadType.ResponseContentPartDone => "response.content_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseContentPartDonePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.done" => ResponseContentPartDonePayloadType.ResponseContentPartDone,
                _ => null,
            };
        }
    }
}