//HintName: G.Models.ResponseOutputItemDonePayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseOutputItemDonePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_item.done")]
        ResponseOutputItemDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputItemDonePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputItemDonePayloadType value)
        {
            return value switch
            {
                ResponseOutputItemDonePayloadType.ResponseOutputItemDone => "response.output_item.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputItemDonePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.done" => ResponseOutputItemDonePayloadType.ResponseOutputItemDone,
                _ => null,
            };
        }
    }
}