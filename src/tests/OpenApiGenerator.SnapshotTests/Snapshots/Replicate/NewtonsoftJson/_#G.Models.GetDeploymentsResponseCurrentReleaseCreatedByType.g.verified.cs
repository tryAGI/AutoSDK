//HintName: G.Models.GetDeploymentsResponseCurrentReleaseCreatedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type of the creator. Can be a user or an organization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDeploymentsResponseCurrentReleaseCreatedByType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    public static class GetDeploymentsResponseCurrentReleaseCreatedByTypeExtensions
    {
        public static string ToValueString(this GetDeploymentsResponseCurrentReleaseCreatedByType value)
        {
            return value switch
            {
                GetDeploymentsResponseCurrentReleaseCreatedByType.Organization => "organization",
                GetDeploymentsResponseCurrentReleaseCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetDeploymentsResponseCurrentReleaseCreatedByType ToEnum(string value)
        {
            return value switch
            {
                "organization" => GetDeploymentsResponseCurrentReleaseCreatedByType.Organization,
                "user" => GetDeploymentsResponseCurrentReleaseCreatedByType.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetDeploymentsResponseCurrentReleaseCreatedByType ToEnum(int value)
        {
            return value switch
            {
                0 => GetDeploymentsResponseCurrentReleaseCreatedByType.Organization,
                1 => GetDeploymentsResponseCurrentReleaseCreatedByType.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}