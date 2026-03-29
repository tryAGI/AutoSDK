//HintName: G.Models.CreateAnthropicBedrockCredentialDTORegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AWS region where Bedrock is configured.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAnthropicBedrockCredentialDTORegion
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
    public static class CreateAnthropicBedrockCredentialDTORegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnthropicBedrockCredentialDTORegion value)
        {
            return value switch
            {
                CreateAnthropicBedrockCredentialDTORegion.ApNortheast1 => "ap-northeast-1",
                CreateAnthropicBedrockCredentialDTORegion.ApSoutheast2 => "ap-southeast-2",
                CreateAnthropicBedrockCredentialDTORegion.EuWest1 => "eu-west-1",
                CreateAnthropicBedrockCredentialDTORegion.EuWest3 => "eu-west-3",
                CreateAnthropicBedrockCredentialDTORegion.UsEast1 => "us-east-1",
                CreateAnthropicBedrockCredentialDTORegion.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnthropicBedrockCredentialDTORegion? ToEnum(string value)
        {
            return value switch
            {
                "ap-northeast-1" => CreateAnthropicBedrockCredentialDTORegion.ApNortheast1,
                "ap-southeast-2" => CreateAnthropicBedrockCredentialDTORegion.ApSoutheast2,
                "eu-west-1" => CreateAnthropicBedrockCredentialDTORegion.EuWest1,
                "eu-west-3" => CreateAnthropicBedrockCredentialDTORegion.EuWest3,
                "us-east-1" => CreateAnthropicBedrockCredentialDTORegion.UsEast1,
                "us-west-2" => CreateAnthropicBedrockCredentialDTORegion.UsWest2,
                _ => null,
            };
        }
    }
}