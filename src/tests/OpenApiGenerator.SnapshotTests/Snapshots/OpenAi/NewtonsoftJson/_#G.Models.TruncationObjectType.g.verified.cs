//HintName: G.Models.TruncationObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The truncation strategy to use for the thread. The default is `auto`. If set to `last_messages`, the thread will be truncated to the n most recent messages in the thread. When set to `auto`, messages in the middle of the thread will be dropped to fit the context length of the model, `max_prompt_tokens`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TruncationObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="last_messages")]
        LastMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TruncationObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TruncationObjectType value)
        {
            return value switch
            {
                TruncationObjectType.Auto => "auto",
                TruncationObjectType.LastMessages => "last_messages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TruncationObjectType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TruncationObjectType.Auto,
                "last_messages" => TruncationObjectType.LastMessages,
                _ => null,
            };
        }
    }
}