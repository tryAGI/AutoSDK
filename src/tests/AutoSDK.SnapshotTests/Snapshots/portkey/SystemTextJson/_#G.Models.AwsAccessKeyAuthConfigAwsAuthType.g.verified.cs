//HintName: G.Models.AwsAccessKeyAuthConfigAwsAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AwsAccessKeyAuthConfigAwsAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        AccessKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AwsAccessKeyAuthConfigAwsAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AwsAccessKeyAuthConfigAwsAuthType value)
        {
            return value switch
            {
                AwsAccessKeyAuthConfigAwsAuthType.AccessKey => "accessKey",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AwsAccessKeyAuthConfigAwsAuthType? ToEnum(string value)
        {
            return value switch
            {
                "accessKey" => AwsAccessKeyAuthConfigAwsAuthType.AccessKey,
                _ => null,
            };
        }
    }
}