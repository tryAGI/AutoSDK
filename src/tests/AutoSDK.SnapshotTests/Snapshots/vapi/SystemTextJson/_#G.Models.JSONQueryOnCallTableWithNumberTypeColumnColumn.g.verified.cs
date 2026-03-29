//HintName: G.Models.JSONQueryOnCallTableWithNumberTypeColumnColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the column that will be queried in the selected table.<br/>
    /// Available columns depend on the selected table.<br/>
    /// Number Type columns are columns where the rows store Number data<br/>
    /// Example: duration
    /// </summary>
    public enum JSONQueryOnCallTableWithNumberTypeColumnColumn
    {
        /// <summary>
        /// 
        /// </summary>
        ArtifactStructuredOutputsOutputID,
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
    public static class JSONQueryOnCallTableWithNumberTypeColumnColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnCallTableWithNumberTypeColumnColumn value)
        {
            return value switch
            {
                JSONQueryOnCallTableWithNumberTypeColumnColumn.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                JSONQueryOnCallTableWithNumberTypeColumnColumn.AverageEndpointingLatency => "averageEndpointingLatency",
                JSONQueryOnCallTableWithNumberTypeColumnColumn.AverageModelLatency => "averageModelLatency",
                JSONQueryOnCallTableWithNumberTypeColumnColumn.AverageTranscriberLatency => "averageTranscriberLatency",
                JSONQueryOnCallTableWithNumberTypeColumnColumn.AverageTurnLatency => "averageTurnLatency",
                JSONQueryOnCallTableWithNumberTypeColumnColumn.AverageVoiceLatency => "averageVoiceLatency",
                JSONQueryOnCallTableWithNumberTypeColumnColumn.Cost => "cost",
                JSONQueryOnCallTableWithNumberTypeColumnColumn.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnCallTableWithNumberTypeColumnColumn? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => JSONQueryOnCallTableWithNumberTypeColumnColumn.ArtifactStructuredOutputsOutputID,
                "averageEndpointingLatency" => JSONQueryOnCallTableWithNumberTypeColumnColumn.AverageEndpointingLatency,
                "averageModelLatency" => JSONQueryOnCallTableWithNumberTypeColumnColumn.AverageModelLatency,
                "averageTranscriberLatency" => JSONQueryOnCallTableWithNumberTypeColumnColumn.AverageTranscriberLatency,
                "averageTurnLatency" => JSONQueryOnCallTableWithNumberTypeColumnColumn.AverageTurnLatency,
                "averageVoiceLatency" => JSONQueryOnCallTableWithNumberTypeColumnColumn.AverageVoiceLatency,
                "cost" => JSONQueryOnCallTableWithNumberTypeColumnColumn.Cost,
                "duration" => JSONQueryOnCallTableWithNumberTypeColumnColumn.Duration,
                _ => null,
            };
        }
    }
}