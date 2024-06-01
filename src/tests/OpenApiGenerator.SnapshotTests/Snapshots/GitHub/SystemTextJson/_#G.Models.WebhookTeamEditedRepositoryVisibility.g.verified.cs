//HintName: G.Models.WebhookTeamEditedRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookTeamEditedRepositoryVisibility
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
    public static class WebhookTeamEditedRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamEditedRepositoryVisibility value)
        {
            return value switch
            {
                WebhookTeamEditedRepositoryVisibility.Public => "public",
                WebhookTeamEditedRepositoryVisibility.Private => "private",
                WebhookTeamEditedRepositoryVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamEditedRepositoryVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookTeamEditedRepositoryVisibility.Public,
                "private" => WebhookTeamEditedRepositoryVisibility.Private,
                "internal" => WebhookTeamEditedRepositoryVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}