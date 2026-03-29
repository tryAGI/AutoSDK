//HintName: G.Models.ViewOptionsTableViewOptionsExcludedMeasureType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ViewOptionsTableViewOptionsExcludedMeasureType
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
    public static class ViewOptionsTableViewOptionsExcludedMeasureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewOptionsTableViewOptionsExcludedMeasureType value)
        {
            return value switch
            {
                ViewOptionsTableViewOptionsExcludedMeasureType.Metadata => "metadata",
                ViewOptionsTableViewOptionsExcludedMeasureType.Metric => "metric",
                ViewOptionsTableViewOptionsExcludedMeasureType.None => "none",
                ViewOptionsTableViewOptionsExcludedMeasureType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewOptionsTableViewOptionsExcludedMeasureType? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => ViewOptionsTableViewOptionsExcludedMeasureType.Metadata,
                "metric" => ViewOptionsTableViewOptionsExcludedMeasureType.Metric,
                "none" => ViewOptionsTableViewOptionsExcludedMeasureType.None,
                "score" => ViewOptionsTableViewOptionsExcludedMeasureType.Score,
                _ => null,
            };
        }
    }
}