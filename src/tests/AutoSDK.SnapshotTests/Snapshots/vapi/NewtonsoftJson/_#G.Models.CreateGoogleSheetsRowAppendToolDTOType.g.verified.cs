//HintName: G.Models.CreateGoogleSheetsRowAppendToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "google.sheets.row.append" for Google Sheets Row Append tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateGoogleSheetsRowAppendToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.sheets.row.append")]
        GoogleSheetsRowAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGoogleSheetsRowAppendToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGoogleSheetsRowAppendToolDTOType value)
        {
            return value switch
            {
                CreateGoogleSheetsRowAppendToolDTOType.GoogleSheetsRowAppend => "google.sheets.row.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGoogleSheetsRowAppendToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "google.sheets.row.append" => CreateGoogleSheetsRowAppendToolDTOType.GoogleSheetsRowAppend,
                _ => null,
            };
        }
    }
}