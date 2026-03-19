//HintName: G.Models.ResponseTextDonePayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseTextDonePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.text.done")]
        ResponseTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseTextDonePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTextDonePayloadType value)
        {
            return value switch
            {
                ResponseTextDonePayloadType.ResponseTextDone => "response.text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTextDonePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.text.done" => ResponseTextDonePayloadType.ResponseTextDone,
                _ => null,
            };
        }
    }
}