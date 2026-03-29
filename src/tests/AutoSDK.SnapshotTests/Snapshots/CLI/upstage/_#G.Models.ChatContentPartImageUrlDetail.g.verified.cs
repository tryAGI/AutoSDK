//HintName: G.Models.ChatContentPartImageUrlDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Image detail level.<br/>
    /// Default Value: auto
    /// </summary>
    public enum ChatContentPartImageUrlDetail
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
    public static class ChatContentPartImageUrlDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentPartImageUrlDetail value)
        {
            return value switch
            {
                ChatContentPartImageUrlDetail.Auto => "auto",
                ChatContentPartImageUrlDetail.High => "high",
                ChatContentPartImageUrlDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentPartImageUrlDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatContentPartImageUrlDetail.Auto,
                "high" => ChatContentPartImageUrlDetail.High,
                "low" => ChatContentPartImageUrlDetail.Low,
                _ => null,
            };
        }
    }
}