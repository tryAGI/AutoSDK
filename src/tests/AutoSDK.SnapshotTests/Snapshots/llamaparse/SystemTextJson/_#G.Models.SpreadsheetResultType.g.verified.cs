//HintName: G.Models.SpreadsheetResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpreadsheetResultType
    {
        /// <summary>
        /// 
        /// </summary>
        CellMetadata,
        /// <summary>
        /// 
        /// </summary>
        Extra,
        /// <summary>
        /// 
        /// </summary>
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpreadsheetResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpreadsheetResultType value)
        {
            return value switch
            {
                SpreadsheetResultType.CellMetadata => "cell_metadata",
                SpreadsheetResultType.Extra => "extra",
                SpreadsheetResultType.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpreadsheetResultType? ToEnum(string value)
        {
            return value switch
            {
                "cell_metadata" => SpreadsheetResultType.CellMetadata,
                "extra" => SpreadsheetResultType.Extra,
                "table" => SpreadsheetResultType.Table,
                _ => null,
            };
        }
    }
}