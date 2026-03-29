//HintName: G.Models.LegacyChatContentVideoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LegacyChatContentVideoType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_video")]
        InputVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyChatContentVideoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyChatContentVideoType value)
        {
            return value switch
            {
                LegacyChatContentVideoType.InputVideo => "input_video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyChatContentVideoType? ToEnum(string value)
        {
            return value switch
            {
                "input_video" => LegacyChatContentVideoType.InputVideo,
                _ => null,
            };
        }
    }
}