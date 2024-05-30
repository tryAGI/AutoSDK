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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDeploymentsResponseResultsCurrentReleaseCreatedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentsResponseResultsCurrentReleaseCreatedByType value)
        {
            return value switch
            {
                ListDeploymentsResponseResultsCurrentReleaseCreatedByType.Organization => "organization",
                ListDeploymentsResponseResultsCurrentReleaseCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentsResponseResultsCurrentReleaseCreatedByType ToEnum(string value)
        {
            return value switch
            {
                "organization" => ListDeploymentsResponseResultsCurrentReleaseCreatedByType.Organization,
                "user" => ListDeploymentsResponseResultsCurrentReleaseCreatedByType.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}