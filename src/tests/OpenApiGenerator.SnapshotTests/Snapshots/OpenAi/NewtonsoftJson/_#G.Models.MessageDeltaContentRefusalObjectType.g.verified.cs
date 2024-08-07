//HintName: G.Models.MessageDeltaContentRefusalObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `refusal`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageDeltaContentRefusalObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="refusal")]
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaContentRefusalObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaContentRefusalObjectType value)
        {
            return value switch
            {
                MessageDeltaContentRefusalObjectType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaContentRefusalObjectType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => MessageDeltaContentRefusalObjectType.Refusal,
                _ => null,
            };
        }
    }
}