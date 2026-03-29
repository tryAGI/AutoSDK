//HintName: G.Models.AwsServiceRoleAuthConfigAwsAuthType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AwsServiceRoleAuthConfigAwsAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        ServiceRole,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AwsServiceRoleAuthConfigAwsAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AwsServiceRoleAuthConfigAwsAuthType value)
        {
            return value switch
            {
                AwsServiceRoleAuthConfigAwsAuthType.ServiceRole => "serviceRole",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AwsServiceRoleAuthConfigAwsAuthType? ToEnum(string value)
        {
            return value switch
            {
                "serviceRole" => AwsServiceRoleAuthConfigAwsAuthType.ServiceRole,
                _ => null,
            };
        }
    }
}