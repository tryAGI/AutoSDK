//HintName: G.Models.AnthropicBedrockCredentialRegion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AWS region where Bedrock is configured.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnthropicBedrockCredentialRegion
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