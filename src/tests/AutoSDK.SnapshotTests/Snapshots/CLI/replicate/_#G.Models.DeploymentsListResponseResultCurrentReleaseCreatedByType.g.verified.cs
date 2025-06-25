//HintName: G.Models.DeploymentsListResponseResultCurrentReleaseCreatedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type of the creator. Can be a user or an organization.
    /// </summary>
    public enum DeploymentsListResponseResultCurrentReleaseCreatedByType
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
    public static class DeploymentsListResponseResultCurrentReleaseCreatedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentsListResponseResultCurrentReleaseCreatedByType value)
        {
            return value switch
            {
                DeploymentsListResponseResultCurrentReleaseCreatedByType.Organization => "organization",
                DeploymentsListResponseResultCurrentReleaseCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentsListResponseResultCurrentReleaseCreatedByType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => DeploymentsListResponseResultCurrentReleaseCreatedByType.Organization,
                "user" => DeploymentsListResponseResultCurrentReleaseCreatedByType.User,
                _ => null,
            };
        }
    }
}