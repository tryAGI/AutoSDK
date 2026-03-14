//HintName: G.Models.CompactionConfigToolEventPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How tool events are included in the compaction input.<br/>
    /// Default Value: include_outputs
    /// </summary>
    public enum CompactionConfigToolEventPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        Exclude,
        /// <summary>
        /// 
        /// </summary>
        IncludeOutputs,
        /// <summary>
        /// 
        /// </summary>
        IncludeAll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompactionConfigToolEventPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompactionConfigToolEventPolicy value)
        {
            return value switch
            {
                CompactionConfigToolEventPolicy.Exclude => "exclude",
                CompactionConfigToolEventPolicy.IncludeOutputs => "include_outputs",
                CompactionConfigToolEventPolicy.IncludeAll => "include_all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompactionConfigToolEventPolicy? ToEnum(string value)
        {
            return value switch
            {
                "exclude" => CompactionConfigToolEventPolicy.Exclude,
                "include_outputs" => CompactionConfigToolEventPolicy.IncludeOutputs,
                "include_all" => CompactionConfigToolEventPolicy.IncludeAll,
                _ => null,
            };
        }
    }
}