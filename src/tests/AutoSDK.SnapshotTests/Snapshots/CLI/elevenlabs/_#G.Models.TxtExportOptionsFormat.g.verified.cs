//HintName: G.Models.TxtExportOptionsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TxtExportOptionsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Txt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TxtExportOptionsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TxtExportOptionsFormat value)
        {
            return value switch
            {
                TxtExportOptionsFormat.Txt => "txt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TxtExportOptionsFormat? ToEnum(string value)
        {
            return value switch
            {
                "txt" => TxtExportOptionsFormat.Txt,
                _ => null,
            };
        }
    }
}