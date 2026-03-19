//HintName: G.Models.ResponseOutputItemAddedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseOutputItemAddedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_item.added")]
        ResponseOutputItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputItemAddedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputItemAddedPayloadType value)
        {
            return value switch
            {
                ResponseOutputItemAddedPayloadType.ResponseOutputItemAdded => "response.output_item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputItemAddedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.added" => ResponseOutputItemAddedPayloadType.ResponseOutputItemAdded,
                _ => null,
            };
        }
    }
}