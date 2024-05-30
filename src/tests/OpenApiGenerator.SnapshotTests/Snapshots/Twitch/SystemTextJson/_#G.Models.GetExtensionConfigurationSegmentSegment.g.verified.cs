//HintName: G.Models.GetExtensionConfigurationSegmentSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetExtensionConfigurationSegmentSegment
    {
        /// <summary>
        /// 
        /// </summary>
        Broadcaster,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Global,
    }

    public static class GetExtensionConfigurationSegmentSegmentExtensions
    {
        public static string ToValueString(this GetExtensionConfigurationSegmentSegment value)
        {
            return value switch
            {
                GetExtensionConfigurationSegmentSegment.Broadcaster => "broadcaster",
                GetExtensionConfigurationSegmentSegment.Developer => "developer",
                GetExtensionConfigurationSegmentSegment.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetExtensionConfigurationSegmentSegment ToEnum(string value)
        {
            return value switch
            {
                "broadcaster" => GetExtensionConfigurationSegmentSegment.Broadcaster,
                "developer" => GetExtensionConfigurationSegmentSegment.Developer,
                "global" => GetExtensionConfigurationSegmentSegment.Global,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetExtensionConfigurationSegmentSegment ToEnum(int value)
        {
            return value switch
            {
                0 => GetExtensionConfigurationSegmentSegment.Broadcaster,
                1 => GetExtensionConfigurationSegmentSegment.Developer,
                2 => GetExtensionConfigurationSegmentSegment.Global,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}