//HintName: G.Models.GetTalkDtoConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTalkDtoConfigResultFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mov")]
        Mov,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp4")]
        Mp4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTalkDtoConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalkDtoConfigResultFormat value)
        {
            return value switch
            {
                GetTalkDtoConfigResultFormat.Mov => "mov",
                GetTalkDtoConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalkDtoConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => GetTalkDtoConfigResultFormat.Mov,
                "mp4" => GetTalkDtoConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}