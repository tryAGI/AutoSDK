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
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtensionConfigurationSegmentSegment
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
    public static class ExtensionConfigurationSegmentSegmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtensionConfigurationSegmentSegment? ToEnum(string value)
        {
            return value switch
            {
                "broadcaster" => ExtensionConfigurationSegmentSegment.Broadcaster,
                "developer" => ExtensionConfigurationSegmentSegment.Developer,
                "global" => ExtensionConfigurationSegmentSegment.Global,
                _ => null,
            };
        }
    }
}