//HintName: G.Models.MessageDeltaContentImageUrlObjectImageUrlDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`.
    /// <br/>Default Value: auto
    /// </summary>
    public enum MessageDeltaContentImageUrlObjectImageUrlDetail
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaContentImageUrlObjectImageUrlDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaContentImageUrlObjectImageUrlDetail value)
        {
            return value switch
            {
                MessageDeltaContentImageUrlObjectImageUrlDetail.Auto => "auto",
                MessageDeltaContentImageUrlObjectImageUrlDetail.Low => "low",
                MessageDeltaContentImageUrlObjectImageUrlDetail.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaContentImageUrlObjectImageUrlDetail ToEnum(string value)
        {
            return value switch
            {
                "auto" => MessageDeltaContentImageUrlObjectImageUrlDetail.Auto,
                "low" => MessageDeltaContentImageUrlObjectImageUrlDetail.Low,
                "high" => MessageDeltaContentImageUrlObjectImageUrlDetail.High,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}