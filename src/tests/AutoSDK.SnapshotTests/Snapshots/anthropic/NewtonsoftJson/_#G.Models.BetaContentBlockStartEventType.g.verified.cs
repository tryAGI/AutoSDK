//HintName: G.Models.BetaContentBlockStartEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: content_block_start
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaContentBlockStartEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content_block_start")]
        ContentBlockStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContentBlockStartEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContentBlockStartEventType value)
        {
            return value switch
            {
                BetaContentBlockStartEventType.ContentBlockStart => "content_block_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContentBlockStartEventType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_start" => BetaContentBlockStartEventType.ContentBlockStart,
                _ => null,
            };
        }
    }
}