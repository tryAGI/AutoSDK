//HintName: G.Models.GetComputeInstanceResponseRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Geographical region where the instance is located<br/>
    /// Example: us-west
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetComputeInstanceResponseRegion
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
    public static class GetComputeInstanceResponseRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseRegion value)
        {
            return value switch
            {
                GetComputeInstanceResponseRegion.EuNorth => "eu-north",
                GetComputeInstanceResponseRegion.EuWest => "eu-west",
                GetComputeInstanceResponseRegion.Other => "other",
                GetComputeInstanceResponseRegion.UsCentral => "us-central",
                GetComputeInstanceResponseRegion.UsEast => "us-east",
                GetComputeInstanceResponseRegion.UsWest => "us-west",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu-north" => GetComputeInstanceResponseRegion.EuNorth,
                "eu-west" => GetComputeInstanceResponseRegion.EuWest,
                "other" => GetComputeInstanceResponseRegion.Other,
                "us-central" => GetComputeInstanceResponseRegion.UsCentral,
                "us-east" => GetComputeInstanceResponseRegion.UsEast,
                "us-west" => GetComputeInstanceResponseRegion.UsWest,
                _ => null,
            };
        }
    }
}