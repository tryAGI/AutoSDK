//HintName: G.Models.WebhookTeamCreatedRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookTeamCreatedRepositoryVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookTeamCreatedRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamCreatedRepositoryVisibility value)
        {
            return value switch
            {
                WebhookTeamCreatedRepositoryVisibility.Public => "public",
                WebhookTeamCreatedRepositoryVisibility.Private => "private",
                WebhookTeamCreatedRepositoryVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamCreatedRepositoryVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookTeamCreatedRepositoryVisibility.Public,
                "private" => WebhookTeamCreatedRepositoryVisibility.Private,
                "internal" => WebhookTeamCreatedRepositoryVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}