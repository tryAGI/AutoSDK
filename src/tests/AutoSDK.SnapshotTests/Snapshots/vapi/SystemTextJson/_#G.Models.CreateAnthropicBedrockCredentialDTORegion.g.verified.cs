//HintName: G.Models.CreateAnthropicBedrockCredentialDTORegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AWS region where Bedrock is configured.
    /// </summary>
    public enum CreateAnthropicBedrockCredentialDTORegion
    {
        /// <summary>
        /// 
        /// </summary>
        ApNortheast1,
        /// <summary>
        /// 
        /// </summary>
        ApSoutheast2,
        /// <summary>
        /// 
        /// </summary>
        EuWest1,
        /// <summary>
        /// 
        /// </summary>
        EuWest3,
        /// <summary>
        /// 
        /// </summary>
        UsEast1,
        /// <summary>
        /// 
        /// </summary>
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