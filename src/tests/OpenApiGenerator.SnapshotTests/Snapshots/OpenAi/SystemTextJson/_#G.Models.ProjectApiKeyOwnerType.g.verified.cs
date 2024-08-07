//HintName: G.Models.ProjectApiKeyOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `user` or `service_account`
    /// </summary>
    public enum ProjectApiKeyOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectApiKeyOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectApiKeyOwnerType value)
        {
            return value switch
            {
                ProjectApiKeyOwnerType.User => "user",
                ProjectApiKeyOwnerType.ServiceAccount => "service_account",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectApiKeyOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "user" => ProjectApiKeyOwnerType.User,
                "service_account" => ProjectApiKeyOwnerType.ServiceAccount,
                _ => null,
            };
        }
    }
}