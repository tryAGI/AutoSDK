//HintName: G.Models.FilterNumberTypeColumnOnCallTableColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the column in the call table that will be filtered on.<br/>
    /// Number Type columns are columns where the rows store data as a number.<br/>
    /// Must be a valid column for the selected table.<br/>
    /// Example: duration
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilterNumberTypeColumnOnCallTableColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="averageEndpointingLatency")]
        AverageEndpointingLatency,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="averageModelLatency")]
        AverageModelLatency,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="averageTranscriberLatency")]
        AverageTranscriberLatency,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="averageTurnLatency")]
        AverageTurnLatency,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="averageVoiceLatency")]
        AverageVoiceLatency,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cost")]
        Cost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="duration")]
        Duration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterNumberTypeColumnOnCallTableColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterNumberTypeColumnOnCallTableColumn value)
        {
            return value switch
            {
                FilterNumberTypeColumnOnCallTableColumn.AverageEndpointingLatency => "averageEndpointingLatency",
                FilterNumberTypeColumnOnCallTableColumn.AverageModelLatency => "averageModelLatency",
                FilterNumberTypeColumnOnCallTableColumn.AverageTranscriberLatency => "averageTranscriberLatency",
                FilterNumberTypeColumnOnCallTableColumn.AverageTurnLatency => "averageTurnLatency",
                FilterNumberTypeColumnOnCallTableColumn.AverageVoiceLatency => "averageVoiceLatency",
                FilterNumberTypeColumnOnCallTableColumn.Cost => "cost",
                FilterNumberTypeColumnOnCallTableColumn.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterNumberTypeColumnOnCallTableColumn? ToEnum(string value)
        {
            return value switch
            {
                "averageEndpointingLatency" => FilterNumberTypeColumnOnCallTableColumn.AverageEndpointingLatency,
                "averageModelLatency" => FilterNumberTypeColumnOnCallTableColumn.AverageModelLatency,
                "averageTranscriberLatency" => FilterNumberTypeColumnOnCallTableColumn.AverageTranscriberLatency,
                "averageTurnLatency" => FilterNumberTypeColumnOnCallTableColumn.AverageTurnLatency,
                "averageVoiceLatency" => FilterNumberTypeColumnOnCallTableColumn.AverageVoiceLatency,
                "cost" => FilterNumberTypeColumnOnCallTableColumn.Cost,
                "duration" => FilterNumberTypeColumnOnCallTableColumn.Duration,
                _ => null,
            };
        }
    }
}