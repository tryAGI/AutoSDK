﻿//HintName: G.Models.DeploymentsUpdateResponseCurrentReleaseCreatedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type of the creator. Can be a user or an organization.
    /// </summary>
    public enum DeploymentsUpdateResponseCurrentReleaseCreatedByType
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
    public static class DeploymentsUpdateResponseCurrentReleaseCreatedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentsUpdateResponseCurrentReleaseCreatedByType value)
        {
            return value switch
            {
                DeploymentsUpdateResponseCurrentReleaseCreatedByType.Organization => "organization",
                DeploymentsUpdateResponseCurrentReleaseCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentsUpdateResponseCurrentReleaseCreatedByType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => DeploymentsUpdateResponseCurrentReleaseCreatedByType.Organization,
                "user" => DeploymentsUpdateResponseCurrentReleaseCreatedByType.User,
                _ => null,
            };
        }
    }
}