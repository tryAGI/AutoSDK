//HintName: G.Models.CreateDeploymentsResponseCurrentReleaseCreatedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type of the creator. Can be a user or an organization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateDeploymentsResponseCurrentReleaseCreatedByType
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentsResponseCurrentReleaseCreatedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentsResponseCurrentReleaseCreatedByType value)
        {
            return value switch
            {
                CreateDeploymentsResponseCurrentReleaseCreatedByType.Organization => "organization",
                CreateDeploymentsResponseCurrentReleaseCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentsResponseCurrentReleaseCreatedByType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => CreateDeploymentsResponseCurrentReleaseCreatedByType.Organization,
                "user" => CreateDeploymentsResponseCurrentReleaseCreatedByType.User,
                _ => null,
            };
        }
    }
}