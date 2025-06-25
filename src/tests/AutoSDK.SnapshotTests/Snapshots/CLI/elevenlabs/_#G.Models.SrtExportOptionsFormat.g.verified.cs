//HintName: G.Models.SrtExportOptionsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SrtExportOptionsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Srt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SrtExportOptionsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SrtExportOptionsFormat value)
        {
            return value switch
            {
                SrtExportOptionsFormat.Srt => "srt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SrtExportOptionsFormat? ToEnum(string value)
        {
            return value switch
            {
                "srt" => SrtExportOptionsFormat.Srt,
                _ => null,
            };
        }
    }
}