//HintName: G.Models.MessageContentImageUrlObjectImageUrlDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the detail level of the image. `low` uses fewer tokens, you can opt in to high resolution using `high`. Default value is `auto`<br/>
    /// Default Value: auto
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
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentImageUrlObjectImageUrlDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentImageUrlObjectImageUrlDetail value)
        {
            return value switch
            {
                MessageContentImageUrlObjectImageUrlDetail.Auto => "auto",
                MessageContentImageUrlObjectImageUrlDetail.High => "high",
                MessageContentImageUrlObjectImageUrlDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentImageUrlObjectImageUrlDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => MessageContentImageUrlObjectImageUrlDetail.Auto,
                "high" => MessageContentImageUrlObjectImageUrlDetail.High,
                "low" => MessageContentImageUrlObjectImageUrlDetail.Low,
                _ => null,
            };
        }
    }
}