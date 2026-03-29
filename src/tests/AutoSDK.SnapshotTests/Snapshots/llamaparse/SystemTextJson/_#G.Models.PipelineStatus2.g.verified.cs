//HintName: G.Models.PipelineStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Deleting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineStatus2 value)
        {
            return value switch
            {
                PipelineStatus2.Created => "CREATED",
                PipelineStatus2.Deleting => "DELETING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineStatus2? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => PipelineStatus2.Created,
                "DELETING" => PipelineStatus2.Deleting,
                _ => null,
            };
        }
    }
}