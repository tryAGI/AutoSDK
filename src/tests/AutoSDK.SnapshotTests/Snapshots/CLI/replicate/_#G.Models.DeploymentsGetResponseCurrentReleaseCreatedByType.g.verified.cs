//HintName: G.Models.DeploymentsGetResponseCurrentReleaseCreatedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type of the creator. Can be a user or an organization.
    /// </summary>
    public enum DeploymentsGetResponseCurrentReleaseCreatedByType
    {
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentsGetResponseCurrentReleaseCreatedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentsGetResponseCurrentReleaseCreatedByType value)
        {
            return value switch
            {
                DeploymentsGetResponseCurrentReleaseCreatedByType.Organization => "organization",
                DeploymentsGetResponseCurrentReleaseCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentsGetResponseCurrentReleaseCreatedByType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => DeploymentsGetResponseCurrentReleaseCreatedByType.Organization,
                "user" => DeploymentsGetResponseCurrentReleaseCreatedByType.User,
                _ => null,
            };
        }
    }
}