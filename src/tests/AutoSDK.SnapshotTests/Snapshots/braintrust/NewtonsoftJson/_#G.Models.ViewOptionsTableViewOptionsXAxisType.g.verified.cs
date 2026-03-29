//HintName: G.Models.ViewOptionsTableViewOptionsXAxisType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ViewOptionsTableViewOptionsXAxisType
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