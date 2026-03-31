//HintName: G.Models.GetTalksResponseTalkConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result
    /// </summary>
    public enum GetTalksResponseTalkConfigResultFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mov,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTalksResponseTalkConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalksResponseTalkConfigResultFormat value)
        {
            return value switch
            {
                GetTalksResponseTalkConfigResultFormat.Mov => "mov",
                GetTalksResponseTalkConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalksResponseTalkConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => GetTalksResponseTalkConfigResultFormat.Mov,
                "mp4" => GetTalksResponseTalkConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}