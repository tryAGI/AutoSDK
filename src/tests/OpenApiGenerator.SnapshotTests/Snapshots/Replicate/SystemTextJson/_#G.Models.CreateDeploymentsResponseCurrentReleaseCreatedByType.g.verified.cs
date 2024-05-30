//HintName: G.Models.CreateDeploymentsResponseCurrentReleaseCreatedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type of the creator. Can be a user or an organization.
    /// </summary>
    public enum CreateDeploymentsResponseCurrentReleaseCreatedByType
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

    public static class CreateDeploymentsResponseCurrentReleaseCreatedByTypeExtensions
    {
        public static string ToValueString(this CreateDeploymentsResponseCurrentReleaseCreatedByType value)
        {
            return value switch
            {
                CreateDeploymentsResponseCurrentReleaseCreatedByType.Organization => "organization",
                CreateDeploymentsResponseCurrentReleaseCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateDeploymentsResponseCurrentReleaseCreatedByType ToEnum(string value)
        {
            return value switch
            {
                "organization" => CreateDeploymentsResponseCurrentReleaseCreatedByType.Organization,
                "user" => CreateDeploymentsResponseCurrentReleaseCreatedByType.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateDeploymentsResponseCurrentReleaseCreatedByType ToEnum(int value)
        {
            return value switch
            {
                0 => CreateDeploymentsResponseCurrentReleaseCreatedByType.Organization,
                1 => CreateDeploymentsResponseCurrentReleaseCreatedByType.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}