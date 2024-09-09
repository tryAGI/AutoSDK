//HintName: G.Models.ChatContentStartEventVariant2DeltaMessageContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatContentStartEventVariant2DeltaMessageContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatContentStartEventVariant2DeltaMessageContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentStartEventVariant2DeltaMessageContentType value)
        {
            return value switch
            {
                ChatContentStartEventVariant2DeltaMessageContentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentStartEventVariant2DeltaMessageContentType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatContentStartEventVariant2DeltaMessageContentType.Text,
                _ => null,
            };
        }
    }
}