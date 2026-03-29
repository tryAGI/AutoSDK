//HintName: G.Models.UpdateAnthropicBedrockCredentialDTORegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AWS region where Bedrock is configured.
    /// </summary>
    public enum UpdateAnthropicBedrockCredentialDTORegion
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