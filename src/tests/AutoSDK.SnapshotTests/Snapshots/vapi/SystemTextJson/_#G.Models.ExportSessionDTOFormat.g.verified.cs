//HintName: G.Models.ExportSessionDTOFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the format of the export.<br/>
    /// @default csv<br/>
    /// Default Value: csv
    /// </summary>
    public enum ExportSessionDTOFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportSessionDTOFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportSessionDTOFormat value)
        {
            return value switch
            {
                ExportSessionDTOFormat.Csv => "csv",
                ExportSessionDTOFormat.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportSessionDTOFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => ExportSessionDTOFormat.Csv,
                "json" => ExportSessionDTOFormat.Json,
                _ => null,
            };
        }
    }
}