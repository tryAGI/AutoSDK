//HintName: G.Models.AnthropicBedrockCredentialRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AWS region where Bedrock is configured.
    /// </summary>
    public enum AnthropicBedrockCredentialRegion
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
    public static class AnthropicBedrockCredentialRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBedrockCredentialRegion value)
        {
            return value switch
            {
                AnthropicBedrockCredentialRegion.ApNortheast1 => "ap-northeast-1",
                AnthropicBedrockCredentialRegion.ApSoutheast2 => "ap-southeast-2",
                AnthropicBedrockCredentialRegion.EuWest1 => "eu-west-1",
                AnthropicBedrockCredentialRegion.EuWest3 => "eu-west-3",
                AnthropicBedrockCredentialRegion.UsEast1 => "us-east-1",
                AnthropicBedrockCredentialRegion.UsWest2 => "us-west-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBedrockCredentialRegion? ToEnum(string value)
        {
            return value switch
            {
                "ap-northeast-1" => AnthropicBedrockCredentialRegion.ApNortheast1,
                "ap-southeast-2" => AnthropicBedrockCredentialRegion.ApSoutheast2,
                "eu-west-1" => AnthropicBedrockCredentialRegion.EuWest1,
                "eu-west-3" => AnthropicBedrockCredentialRegion.EuWest3,
                "us-east-1" => AnthropicBedrockCredentialRegion.UsEast1,
                "us-west-2" => AnthropicBedrockCredentialRegion.UsWest2,
                _ => null,
            };
        }
    }
}