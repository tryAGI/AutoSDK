//HintName: G.Models.BetaMessageStreamEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaMessageStreamEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ContentBlockDelta,
        /// <summary>
        /// 
        /// </summary>
        ContentBlockStart,
        /// <summary>
        /// 
        /// </summary>
        ContentBlockStop,
        /// <summary>
        /// 
        /// </summary>
        MessageDelta,
        /// <summary>
        /// 
        /// </summary>
        MessageStart,
        /// <summary>
        /// 
        /// </summary>
        MessageStop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMessageStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMessageStreamEventDiscriminatorType value)
        {
            return value switch
            {
                BetaMessageStreamEventDiscriminatorType.ContentBlockDelta => "content_block_delta",
                BetaMessageStreamEventDiscriminatorType.ContentBlockStart => "content_block_start",
                BetaMessageStreamEventDiscriminatorType.ContentBlockStop => "content_block_stop",
                BetaMessageStreamEventDiscriminatorType.MessageDelta => "message_delta",
                BetaMessageStreamEventDiscriminatorType.MessageStart => "message_start",
                BetaMessageStreamEventDiscriminatorType.MessageStop => "message_stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMessageStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_delta" => BetaMessageStreamEventDiscriminatorType.ContentBlockDelta,
                "content_block_start" => BetaMessageStreamEventDiscriminatorType.ContentBlockStart,
                "content_block_stop" => BetaMessageStreamEventDiscriminatorType.ContentBlockStop,
                "message_delta" => BetaMessageStreamEventDiscriminatorType.MessageDelta,
                "message_start" => BetaMessageStreamEventDiscriminatorType.MessageStart,
                "message_stop" => BetaMessageStreamEventDiscriminatorType.MessageStop,
                _ => null,
            };
        }
    }
}