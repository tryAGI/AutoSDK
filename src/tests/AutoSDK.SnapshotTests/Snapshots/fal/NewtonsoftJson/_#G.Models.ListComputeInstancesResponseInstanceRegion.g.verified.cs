//HintName: G.Models.ListComputeInstancesResponseInstanceRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Geographical region where the instance is located<br/>
    /// Example: us-west
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListComputeInstancesResponseInstanceRegion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eu-north")]
        EuNorth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eu-west")]
        EuWest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="us-central")]
        UsCentral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="us-east")]
        UsEast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="us-west")]
        UsWest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListComputeInstancesResponseInstanceRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListComputeInstancesResponseInstanceRegion value)
        {
            return value switch
            {
                ListComputeInstancesResponseInstanceRegion.EuNorth => "eu-north",
                ListComputeInstancesResponseInstanceRegion.EuWest => "eu-west",
                ListComputeInstancesResponseInstanceRegion.Other => "other",
                ListComputeInstancesResponseInstanceRegion.UsCentral => "us-central",
                ListComputeInstancesResponseInstanceRegion.UsEast => "us-east",
                ListComputeInstancesResponseInstanceRegion.UsWest => "us-west",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListComputeInstancesResponseInstanceRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu-north" => ListComputeInstancesResponseInstanceRegion.EuNorth,
                "eu-west" => ListComputeInstancesResponseInstanceRegion.EuWest,
                "other" => ListComputeInstancesResponseInstanceRegion.Other,
                "us-central" => ListComputeInstancesResponseInstanceRegion.UsCentral,
                "us-east" => ListComputeInstancesResponseInstanceRegion.UsEast,
                "us-west" => ListComputeInstancesResponseInstanceRegion.UsWest,
                _ => null,
            };
        }
    }
}