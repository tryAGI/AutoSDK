//HintName: G.Models.ViewOptionsTableViewOptionsSymbolGroupingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ViewOptionsTableViewOptionsSymbolGroupingType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Metric,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewOptionsTableViewOptionsSymbolGroupingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewOptionsTableViewOptionsSymbolGroupingType value)
        {
            return value switch
            {
                ViewOptionsTableViewOptionsSymbolGroupingType.Metadata => "metadata",
                ViewOptionsTableViewOptionsSymbolGroupingType.Metric => "metric",
                ViewOptionsTableViewOptionsSymbolGroupingType.None => "none",
                ViewOptionsTableViewOptionsSymbolGroupingType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewOptionsTableViewOptionsSymbolGroupingType? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => ViewOptionsTableViewOptionsSymbolGroupingType.Metadata,
                "metric" => ViewOptionsTableViewOptionsSymbolGroupingType.Metric,
                "none" => ViewOptionsTableViewOptionsSymbolGroupingType.None,
                "score" => ViewOptionsTableViewOptionsSymbolGroupingType.Score,
                _ => null,
            };
        }
    }
}