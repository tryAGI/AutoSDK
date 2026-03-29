//HintName: G.Models.ChatContentImageImageUrlDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Image detail level for vision models
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatContentImageImageUrlDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
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