//HintName: G.Models.MessageContentImageUrlObjectImageUrlDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`. Default value is `auto`
    /// <br/>Default Value: auto
    /// </summary>
    public enum MessageContentImageUrlObjectImageUrlDetail
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

    public static class MessageContentImageUrlObjectImageUrlDetailExtensions
    {
        public static string ToValueString(this MessageContentImageUrlObjectImageUrlDetail value)
        {
            return value switch
            {
                MessageContentImageUrlObjectImageUrlDetail.Auto => "auto",
                MessageContentImageUrlObjectImageUrlDetail.Low => "low",
                MessageContentImageUrlObjectImageUrlDetail.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageContentImageUrlObjectImageUrlDetail ToEnum(string value)
        {
            return value switch
            {
                "auto" => MessageContentImageUrlObjectImageUrlDetail.Auto,
                "low" => MessageContentImageUrlObjectImageUrlDetail.Low,
                "high" => MessageContentImageUrlObjectImageUrlDetail.High,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageContentImageUrlObjectImageUrlDetail ToEnum(int value)
        {
            return value switch
            {
                0 => MessageContentImageUrlObjectImageUrlDetail.Auto,
                1 => MessageContentImageUrlObjectImageUrlDetail.Low,
                2 => MessageContentImageUrlObjectImageUrlDetail.High,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}