//HintName: G.Models.ChatContentVideoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatContentVideoType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video_url")]
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatContentVideoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatContentVideoType value)
        {
            return value switch
            {
                ChatContentVideoType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatContentVideoType? ToEnum(string value)
        {
            return value switch
            {
                "video_url" => ChatContentVideoType.VideoUrl,
                _ => null,
            };
        }
    }
}