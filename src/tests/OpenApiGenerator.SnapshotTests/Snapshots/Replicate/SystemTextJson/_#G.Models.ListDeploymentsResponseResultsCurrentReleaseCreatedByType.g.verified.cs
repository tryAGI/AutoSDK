//HintName: G.Models.ListDeploymentsResponseResultsCurrentReleaseCreatedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type of the creator. Can be a user or an organization.
    /// </summary>
    public enum ListDeploymentsResponseResultsCurrentReleaseCreatedByType
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

    public static class ListDeploymentsResponseResultsCurrentReleaseCreatedByTypeExtensions
    {
        public static string ToValueString(this ListDeploymentsResponseResultsCurrentReleaseCreatedByType value)
        {
            return value switch
            {
                ListDeploymentsResponseResultsCurrentReleaseCreatedByType.Organization => "organization",
                ListDeploymentsResponseResultsCurrentReleaseCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListDeploymentsResponseResultsCurrentReleaseCreatedByType ToEnum(string value)
        {
            return value switch
            {
                "organization" => ListDeploymentsResponseResultsCurrentReleaseCreatedByType.Organization,
                "user" => ListDeploymentsResponseResultsCurrentReleaseCreatedByType.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListDeploymentsResponseResultsCurrentReleaseCreatedByType ToEnum(int value)
        {
            return value switch
            {
                0 => ListDeploymentsResponseResultsCurrentReleaseCreatedByType.Organization,
                1 => ListDeploymentsResponseResultsCurrentReleaseCreatedByType.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}