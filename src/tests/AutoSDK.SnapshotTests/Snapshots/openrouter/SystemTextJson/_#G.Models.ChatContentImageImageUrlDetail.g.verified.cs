//HintName: G.Models.ChatContentImageImageUrlDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Image detail level for vision models
    /// </summary>
    public enum ChatContentImageImageUrlDetail
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
    public static class ChatContentImageImageUrlDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentImageImageUrlDetail value)
        {
            return value switch
            {
                ChatContentImageImageUrlDetail.Auto => "auto",
                ChatContentImageImageUrlDetail.High => "high",
                ChatContentImageImageUrlDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentImageImageUrlDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatContentImageImageUrlDetail.Auto,
                "high" => ChatContentImageImageUrlDetail.High,
                "low" => ChatContentImageImageUrlDetail.Low,
                _ => null,
            };
        }
    }
}