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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SetExtensionConfigurationSegmentBodySegmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetExtensionConfigurationSegmentBodySegment? ToEnum(string value)
        {
            return value switch
            {
                "broadcaster" => SetExtensionConfigurationSegmentBodySegment.Broadcaster,
                "developer" => SetExtensionConfigurationSegmentBodySegment.Developer,
                "global" => SetExtensionConfigurationSegmentBodySegment.Global,
                _ => null,
            };
        }
    }
}