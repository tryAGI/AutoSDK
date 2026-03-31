//HintName: G.Models.ViewOptionsTableViewOptionsXAxisType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ViewOptionsTableViewOptionsXAxisType
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
    public static class ViewOptionsTableViewOptionsXAxisTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewOptionsTableViewOptionsXAxisType value)
        {
            return value switch
            {
                ViewOptionsTableViewOptionsXAxisType.Metadata => "metadata",
                ViewOptionsTableViewOptionsXAxisType.Metric => "metric",
                ViewOptionsTableViewOptionsXAxisType.None => "none",
                ViewOptionsTableViewOptionsXAxisType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewOptionsTableViewOptionsXAxisType? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => ViewOptionsTableViewOptionsXAxisType.Metadata,
                "metric" => ViewOptionsTableViewOptionsXAxisType.Metric,
                "none" => ViewOptionsTableViewOptionsXAxisType.None,
                "score" => ViewOptionsTableViewOptionsXAxisType.Score,
                _ => null,
            };
        }
    }
}