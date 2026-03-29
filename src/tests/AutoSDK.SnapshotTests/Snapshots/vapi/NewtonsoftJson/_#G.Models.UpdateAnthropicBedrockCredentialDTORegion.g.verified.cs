//HintName: G.Models.UpdateAnthropicBedrockCredentialDTORegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AWS region where Bedrock is configured.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateAnthropicBedrockCredentialDTORegion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ap-northeast-1")]
        ApNortheast1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ap-southeast-2")]
        ApSoutheast2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eu-west-1")]
        EuWest1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eu-west-3")]
        EuWest3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="us-east-1")]
        UsEast1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="us-west-2")]
        UsWest2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAnthropicBedrockCredentialDTORegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAnthropicBedrockCredentialDTORegion value)
        {
            return value switch
            {
                UpdateAnthropicBedrockCredentialDTORegion.ApNortheast1 => "ap-northeast-1",
                UpdateAnthropicBedrockCredentialDTORegion.ApSoutheast2 => "ap-southeast-2",
                UpdateAnthropicBedrockCredentialDTORegion.EuWest1 => "eu-west-1",
                UpdateAnthropicBedrockCredentialDTORegion.EuWest3 => "eu-west-3",
                UpdateAnthropicBedrockCredentialDTORegion.UsEast1 => "us-east-1",
                UpdateAnthropicBedrockCredentialDTORegion.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAnthropicBedrockCredentialDTORegion? ToEnum(string value)
        {
            return value switch
            {
                "ap-northeast-1" => UpdateAnthropicBedrockCredentialDTORegion.ApNortheast1,
                "ap-southeast-2" => UpdateAnthropicBedrockCredentialDTORegion.ApSoutheast2,
                "eu-west-1" => UpdateAnthropicBedrockCredentialDTORegion.EuWest1,
                "eu-west-3" => UpdateAnthropicBedrockCredentialDTORegion.EuWest3,
                "us-east-1" => UpdateAnthropicBedrockCredentialDTORegion.UsEast1,
                "us-west-2" => UpdateAnthropicBedrockCredentialDTORegion.UsWest2,
                _ => null,
            };
        }
    }
}