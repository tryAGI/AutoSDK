//HintName: G.Models.ExtensionConfigurationSegmentSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of segment. Possible values are:   
    ///   
    /// * broadcaster
    /// * developer
    /// * global
    /// </summary>
    public enum ExtensionConfigurationSegmentSegment
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

    public static class ExtensionConfigurationSegmentSegmentExtensions
    {
        public static string ToValueString(this ExtensionConfigurationSegmentSegment value)
        {
            return value switch
            {
                ExtensionConfigurationSegmentSegment.Broadcaster => "broadcaster",
                ExtensionConfigurationSegmentSegment.Developer => "developer",
                ExtensionConfigurationSegmentSegment.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionConfigurationSegmentSegment ToEnum(string value)
        {
            return value switch
            {
                "broadcaster" => ExtensionConfigurationSegmentSegment.Broadcaster,
                "developer" => ExtensionConfigurationSegmentSegment.Developer,
                "global" => ExtensionConfigurationSegmentSegment.Global,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ExtensionConfigurationSegmentSegment ToEnum(int value)
        {
            return value switch
            {
                0 => ExtensionConfigurationSegmentSegment.Broadcaster,
                1 => ExtensionConfigurationSegmentSegment.Developer,
                2 => ExtensionConfigurationSegmentSegment.Global,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}