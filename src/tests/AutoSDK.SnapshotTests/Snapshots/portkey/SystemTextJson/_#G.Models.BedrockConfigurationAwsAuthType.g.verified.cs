//HintName: G.Models.BedrockConfigurationAwsAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AWS authentication type
    /// </summary>
    public enum BedrockConfigurationAwsAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        AccessKey,
        /// <summary>
        /// 
        /// </summary>
        AssumedRole,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BedrockConfigurationAwsAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BedrockConfigurationAwsAuthType value)
        {
            return value switch
            {
                BedrockConfigurationAwsAuthType.AccessKey => "accessKey",
                BedrockConfigurationAwsAuthType.AssumedRole => "assumedRole",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BedrockConfigurationAwsAuthType? ToEnum(string value)
        {
            return value switch
            {
                "accessKey" => BedrockConfigurationAwsAuthType.AccessKey,
                "assumedRole" => BedrockConfigurationAwsAuthType.AssumedRole,
                _ => null,
            };
        }
    }
}