//HintName: G.Models.GoogleSheetsRowAppendToolProviderDetailsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "google.sheets.row.append" for Google Sheets tool.
    /// </summary>
    public enum GoogleSheetsRowAppendToolProviderDetailsType
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleSheetsRowAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleSheetsRowAppendToolProviderDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleSheetsRowAppendToolProviderDetailsType value)
        {
            return value switch
            {
                GoogleSheetsRowAppendToolProviderDetailsType.GoogleSheetsRowAppend => "google.sheets.row.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleSheetsRowAppendToolProviderDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "google.sheets.row.append" => GoogleSheetsRowAppendToolProviderDetailsType.GoogleSheetsRowAppend,
                _ => null,
            };
        }
    }
}