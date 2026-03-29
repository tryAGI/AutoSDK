//HintName: G.Models.ViewOptionsTableViewOptionsYMetricType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ViewOptionsTableViewOptionsYMetricType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="metadata")]
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="metric")]
        Metric,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="score")]
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewOptionsTableViewOptionsYMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewOptionsTableViewOptionsYMetricType value)
        {
            return value switch
            {
                ViewOptionsTableViewOptionsYMetricType.Metadata => "metadata",
                ViewOptionsTableViewOptionsYMetricType.Metric => "metric",
                ViewOptionsTableViewOptionsYMetricType.None => "none",
                ViewOptionsTableViewOptionsYMetricType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewOptionsTableViewOptionsYMetricType? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => ViewOptionsTableViewOptionsYMetricType.Metadata,
                "metric" => ViewOptionsTableViewOptionsYMetricType.Metric,
                "none" => ViewOptionsTableViewOptionsYMetricType.None,
                "score" => ViewOptionsTableViewOptionsYMetricType.Score,
                _ => null,
            };
        }
    }
}