//HintName: G.Models.SetExtensionConfigurationSegmentBodySegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The configuration segment to update. Possible case-sensitive values are:  
    ///   
    /// * broadcaster
    /// * developer
    /// * global
    /// </summary>
    public enum SetExtensionConfigurationSegmentBodySegment
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

    public static class SetExtensionConfigurationSegmentBodySegmentExtensions
    {
        public static string ToValueString(this SetExtensionConfigurationSegmentBodySegment value)
        {
            return value switch
            {
                SetExtensionConfigurationSegmentBodySegment.Broadcaster => "broadcaster",
                SetExtensionConfigurationSegmentBodySegment.Developer => "developer",
                SetExtensionConfigurationSegmentBodySegment.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SetExtensionConfigurationSegmentBodySegment ToEnum(string value)
        {
            return value switch
            {
                "broadcaster" => SetExtensionConfigurationSegmentBodySegment.Broadcaster,
                "developer" => SetExtensionConfigurationSegmentBodySegment.Developer,
                "global" => SetExtensionConfigurationSegmentBodySegment.Global,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SetExtensionConfigurationSegmentBodySegment ToEnum(int value)
        {
            return value switch
            {
                0 => SetExtensionConfigurationSegmentBodySegment.Broadcaster,
                1 => SetExtensionConfigurationSegmentBodySegment.Developer,
                2 => SetExtensionConfigurationSegmentBodySegment.Global,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}