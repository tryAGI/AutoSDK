//HintName: G.Models.GetExtensionConfigurationSegmentSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetExtensionConfigurationSegmentSegment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="broadcaster")]
        Broadcaster,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="global")]
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetExtensionConfigurationSegmentSegmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExtensionConfigurationSegmentSegment? ToEnum(string value)
        {
            return value switch
            {
                "broadcaster" => GetExtensionConfigurationSegmentSegment.Broadcaster,
                "developer" => GetExtensionConfigurationSegmentSegment.Developer,
                "global" => GetExtensionConfigurationSegmentSegment.Global,
                _ => null,
            };
        }
    }
}