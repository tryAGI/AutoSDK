//HintName: G.Models.CreateComputeInstanceResponseRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Geographical region where the instance is located<br/>
    /// Example: us-west
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateComputeInstanceResponseRegion
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
    public static class CreateComputeInstanceResponseRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseRegion value)
        {
            return value switch
            {
                CreateComputeInstanceResponseRegion.EuNorth => "eu-north",
                CreateComputeInstanceResponseRegion.EuWest => "eu-west",
                CreateComputeInstanceResponseRegion.Other => "other",
                CreateComputeInstanceResponseRegion.UsCentral => "us-central",
                CreateComputeInstanceResponseRegion.UsEast => "us-east",
                CreateComputeInstanceResponseRegion.UsWest => "us-west",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu-north" => CreateComputeInstanceResponseRegion.EuNorth,
                "eu-west" => CreateComputeInstanceResponseRegion.EuWest,
                "other" => CreateComputeInstanceResponseRegion.Other,
                "us-central" => CreateComputeInstanceResponseRegion.UsCentral,
                "us-east" => CreateComputeInstanceResponseRegion.UsEast,
                "us-west" => CreateComputeInstanceResponseRegion.UsWest,
                _ => null,
            };
        }
    }
}