//HintName: G.Models.GoogleSheetsRowAppendToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "google.sheets.row.append" for Google Sheets Row Append tool.
    /// </summary>
    public enum GoogleSheetsRowAppendToolType
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleSheetsRowAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleSheetsRowAppendToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleSheetsRowAppendToolType value)
        {
            return value switch
            {
                GoogleSheetsRowAppendToolType.GoogleSheetsRowAppend => "google.sheets.row.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleSheetsRowAppendToolType? ToEnum(string value)
        {
            return value switch
            {
                "google.sheets.row.append" => GoogleSheetsRowAppendToolType.GoogleSheetsRowAppend,
                _ => null,
            };
        }
    }
}