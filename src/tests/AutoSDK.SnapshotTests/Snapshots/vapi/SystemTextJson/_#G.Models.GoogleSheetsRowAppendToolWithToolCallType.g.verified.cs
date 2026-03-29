//HintName: G.Models.GoogleSheetsRowAppendToolWithToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "google.sheets.row.append" for Google Sheets Row Append tool.
    /// </summary>
    public enum GoogleSheetsRowAppendToolWithToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleSheetsRowAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleSheetsRowAppendToolWithToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleSheetsRowAppendToolWithToolCallType value)
        {
            return value switch
            {
                GoogleSheetsRowAppendToolWithToolCallType.GoogleSheetsRowAppend => "google.sheets.row.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleSheetsRowAppendToolWithToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "google.sheets.row.append" => GoogleSheetsRowAppendToolWithToolCallType.GoogleSheetsRowAppend,
                _ => null,
            };
        }
    }
}