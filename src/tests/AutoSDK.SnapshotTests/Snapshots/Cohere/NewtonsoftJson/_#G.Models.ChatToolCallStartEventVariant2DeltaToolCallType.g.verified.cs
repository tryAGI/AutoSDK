//HintName: G.Models.ChatToolCallStartEventVariant2DeltaToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatToolCallStartEventVariant2DeltaToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatToolCallStartEventVariant2DeltaToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatToolCallStartEventVariant2DeltaToolCallType value)
        {
            return value switch
            {
                ChatToolCallStartEventVariant2DeltaToolCallType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatToolCallStartEventVariant2DeltaToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatToolCallStartEventVariant2DeltaToolCallType.Function,
                _ => null,
            };
        }
    }
}