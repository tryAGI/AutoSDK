//HintName: G.Models.JobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of job.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rebuild_vector_index")]
        RebuildVectorIndex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="replace_filter_attributes")]
        ReplaceFilterAttributes,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobType value)
        {
            return value switch
            {
                JobType.RebuildVectorIndex => "rebuild_vector_index",
                JobType.ReplaceFilterAttributes => "replace_filter_attributes",
                JobType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobType? ToEnum(string value)
        {
            return value switch
            {
                "rebuild_vector_index" => JobType.RebuildVectorIndex,
                "replace_filter_attributes" => JobType.ReplaceFilterAttributes,
                "unknown" => JobType.Unknown,
                _ => null,
            };
        }
    }
}