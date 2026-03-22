//HintName: G.Models.MergedUpstreamMergeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MergedUpstreamMergeType
    {
        /// <summary>
        /// 
        /// </summary>
        FastForward,
        /// <summary>
        /// 
        /// </summary>
        Merge,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MergedUpstreamMergeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MergedUpstreamMergeType value)
        {
            return value switch
            {
                MergedUpstreamMergeType.FastForward => "fast-forward",
                MergedUpstreamMergeType.Merge => "merge",
                MergedUpstreamMergeType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MergedUpstreamMergeType? ToEnum(string value)
        {
            return value switch
            {
                "fast-forward" => MergedUpstreamMergeType.FastForward,
                "merge" => MergedUpstreamMergeType.Merge,
                "none" => MergedUpstreamMergeType.None,
                _ => null,
            };
        }
    }
}