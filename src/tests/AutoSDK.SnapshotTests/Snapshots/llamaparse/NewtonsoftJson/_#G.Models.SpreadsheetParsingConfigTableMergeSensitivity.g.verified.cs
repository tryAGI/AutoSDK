//HintName: G.Models.SpreadsheetParsingConfigTableMergeSensitivity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Influences how likely similar-looking regions are merged into a single table. Useful for spreadsheets that either have sparse tables (strong merging) or many distinct tables close together (weak merging).<br/>
    /// Default Value: strong
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpreadsheetParsingConfigTableMergeSensitivity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="strong")]
        Strong,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="weak")]
        Weak,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpreadsheetParsingConfigTableMergeSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpreadsheetParsingConfigTableMergeSensitivity value)
        {
            return value switch
            {
                SpreadsheetParsingConfigTableMergeSensitivity.Strong => "strong",
                SpreadsheetParsingConfigTableMergeSensitivity.Weak => "weak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpreadsheetParsingConfigTableMergeSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "strong" => SpreadsheetParsingConfigTableMergeSensitivity.Strong,
                "weak" => SpreadsheetParsingConfigTableMergeSensitivity.Weak,
                _ => null,
            };
        }
    }
}