//HintName: G.Models.AnimateConfigDtoResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the file format of the animated video result
    /// </summary>
    public enum AnimateConfigDtoResultFormat
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
    public static class AnimateConfigDtoResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnimateConfigDtoResultFormat value)
        {
            return value switch
            {
                AnimateConfigDtoResultFormat.Mov => "mov",
                AnimateConfigDtoResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnimateConfigDtoResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => AnimateConfigDtoResultFormat.Mov,
                "mp4" => AnimateConfigDtoResultFormat.Mp4,
                _ => null,
            };
        }
    }
}