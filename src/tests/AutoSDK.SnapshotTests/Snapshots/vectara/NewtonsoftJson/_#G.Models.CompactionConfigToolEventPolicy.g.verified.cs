//HintName: G.Models.CompactionConfigToolEventPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How tool events are included in the compaction input.<br/>
    /// Default Value: include_outputs
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompactionConfigToolEventPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exclude")]
        Exclude,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="include_all")]
        IncludeAll,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="include_outputs")]
        IncludeOutputs,
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
                CompactionConfigToolEventPolicy.IncludeAll => "include_all",
                CompactionConfigToolEventPolicy.IncludeOutputs => "include_outputs",
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
                "include_all" => CompactionConfigToolEventPolicy.IncludeAll,
                "include_outputs" => CompactionConfigToolEventPolicy.IncludeOutputs,
                _ => null,
            };
        }
    }
}