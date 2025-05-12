//HintName: G.Models.RunStatsGroupByAttribute.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStatsGroupByAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        RunType,
        /// <summary>
        /// 
        /// </summary>
        Tag,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStatsGroupByAttributeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStatsGroupByAttribute value)
        {
            return value switch
            {
                RunStatsGroupByAttribute.Name => "name",
                RunStatsGroupByAttribute.RunType => "run_type",
                RunStatsGroupByAttribute.Tag => "tag",
                RunStatsGroupByAttribute.Metadata => "metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStatsGroupByAttribute? ToEnum(string value)
        {
            return value switch
            {
                "name" => RunStatsGroupByAttribute.Name,
                "run_type" => RunStatsGroupByAttribute.RunType,
                "tag" => RunStatsGroupByAttribute.Tag,
                "metadata" => RunStatsGroupByAttribute.Metadata,
                _ => null,
            };
        }
    }
}