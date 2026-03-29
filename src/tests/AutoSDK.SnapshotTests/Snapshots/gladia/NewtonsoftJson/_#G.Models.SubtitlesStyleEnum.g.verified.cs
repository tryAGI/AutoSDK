//HintName: G.Models.SubtitlesStyleEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Style of the subtitles. Compliance mode refers to : https://loc.gov/preservation/digital/formats//fdd/fdd000569.shtml#:~:text=SRT%20files%20are%20basic%20text,alongside%2C%20example%3A%20%22MyVideo123
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SubtitlesStyleEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="compliance")]
        Compliance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubtitlesStyleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubtitlesStyleEnum value)
        {
            return value switch
            {
                SubtitlesStyleEnum.Compliance => "compliance",
                SubtitlesStyleEnum.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubtitlesStyleEnum? ToEnum(string value)
        {
            return value switch
            {
                "compliance" => SubtitlesStyleEnum.Compliance,
                "default" => SubtitlesStyleEnum.Default,
                _ => null,
            };
        }
    }
}