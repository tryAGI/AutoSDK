//HintName: G.Models.FilterNumberArrayTypeColumnOnCallTableColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the column in the call table that will be filtered on.<br/>
    /// Number Array Type columns are the same as Number Type columns, but provides the ability to filter on multiple values provided as an array.<br/>
    /// Must be a valid column for the selected table.<br/>
    /// Example: duration
    /// </summary>
    public enum FilterNumberArrayTypeColumnOnCallTableColumn
    {
        /// <summary>
        /// 
        /// </summary>
        AverageEndpointingLatency,
        /// <summary>
        /// 
        /// </summary>
        AverageModelLatency,
        /// <summary>
        /// 
        /// </summary>
        AverageTranscriberLatency,
        /// <summary>
        /// 
        /// </summary>
        AverageTurnLatency,
        /// <summary>
        /// 
        /// </summary>
        AverageVoiceLatency,
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        Duration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterNumberArrayTypeColumnOnCallTableColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterNumberArrayTypeColumnOnCallTableColumn value)
        {
            return value switch
            {
                FilterNumberArrayTypeColumnOnCallTableColumn.AverageEndpointingLatency => "averageEndpointingLatency",
                FilterNumberArrayTypeColumnOnCallTableColumn.AverageModelLatency => "averageModelLatency",
                FilterNumberArrayTypeColumnOnCallTableColumn.AverageTranscriberLatency => "averageTranscriberLatency",
                FilterNumberArrayTypeColumnOnCallTableColumn.AverageTurnLatency => "averageTurnLatency",
                FilterNumberArrayTypeColumnOnCallTableColumn.AverageVoiceLatency => "averageVoiceLatency",
                FilterNumberArrayTypeColumnOnCallTableColumn.Cost => "cost",
                FilterNumberArrayTypeColumnOnCallTableColumn.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterNumberArrayTypeColumnOnCallTableColumn? ToEnum(string value)
        {
            return value switch
            {
                "averageEndpointingLatency" => FilterNumberArrayTypeColumnOnCallTableColumn.AverageEndpointingLatency,
                "averageModelLatency" => FilterNumberArrayTypeColumnOnCallTableColumn.AverageModelLatency,
                "averageTranscriberLatency" => FilterNumberArrayTypeColumnOnCallTableColumn.AverageTranscriberLatency,
                "averageTurnLatency" => FilterNumberArrayTypeColumnOnCallTableColumn.AverageTurnLatency,
                "averageVoiceLatency" => FilterNumberArrayTypeColumnOnCallTableColumn.AverageVoiceLatency,
                "cost" => FilterNumberArrayTypeColumnOnCallTableColumn.Cost,
                "duration" => FilterNumberArrayTypeColumnOnCallTableColumn.Duration,
                _ => null,
            };
        }
    }
}