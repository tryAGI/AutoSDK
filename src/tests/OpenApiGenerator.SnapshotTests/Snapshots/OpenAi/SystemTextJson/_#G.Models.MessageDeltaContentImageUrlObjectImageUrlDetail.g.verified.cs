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

    public static class MessageDeltaContentImageUrlObjectImageUrlDetailExtensions
    {
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
        public static MessageDeltaContentImageUrlObjectImageUrlDetail ToEnum(int value)
        {
            return value switch
            {
                0 => MessageDeltaContentImageUrlObjectImageUrlDetail.Auto,
                1 => MessageDeltaContentImageUrlObjectImageUrlDetail.Low,
                2 => MessageDeltaContentImageUrlObjectImageUrlDetail.High,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}