//HintName: G.Models.UpdateDeploymentsResponseCurrentReleaseCreatedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type of the creator. Can be a user or an organization.
    /// </summary>
    public enum UpdateDeploymentsResponseCurrentReleaseCreatedByType
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

    public static class UpdateDeploymentsResponseCurrentReleaseCreatedByTypeExtensions
    {
        public static string ToValueString(this UpdateDeploymentsResponseCurrentReleaseCreatedByType value)
        {
            return value switch
            {
                UpdateDeploymentsResponseCurrentReleaseCreatedByType.Organization => "organization",
                UpdateDeploymentsResponseCurrentReleaseCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateDeploymentsResponseCurrentReleaseCreatedByType ToEnum(string value)
        {
            return value switch
            {
                "organization" => UpdateDeploymentsResponseCurrentReleaseCreatedByType.Organization,
                "user" => UpdateDeploymentsResponseCurrentReleaseCreatedByType.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateDeploymentsResponseCurrentReleaseCreatedByType ToEnum(int value)
        {
            return value switch
            {
                0 => UpdateDeploymentsResponseCurrentReleaseCreatedByType.Organization,
                1 => UpdateDeploymentsResponseCurrentReleaseCreatedByType.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}