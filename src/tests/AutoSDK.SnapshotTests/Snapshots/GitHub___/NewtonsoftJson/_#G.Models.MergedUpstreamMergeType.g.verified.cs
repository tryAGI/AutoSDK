//HintName: G.Models.MergedUpstreamMergeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MergedUpstreamMergeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge")]
        Merge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast-forward")]
        FastForward,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
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
                MergedUpstreamMergeType.Merge => "merge",
                MergedUpstreamMergeType.FastForward => "fast-forward",
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
                "merge" => MergedUpstreamMergeType.Merge,
                "fast-forward" => MergedUpstreamMergeType.FastForward,
                "none" => MergedUpstreamMergeType.None,
                _ => null,
            };
        }
    }
}