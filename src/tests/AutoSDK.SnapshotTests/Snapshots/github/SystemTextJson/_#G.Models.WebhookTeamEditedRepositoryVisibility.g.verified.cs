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
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
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
                WebhookTeamEditedRepositoryVisibility.Internal => "internal",
                WebhookTeamEditedRepositoryVisibility.Private => "private",
                WebhookTeamEditedRepositoryVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamEditedRepositoryVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookTeamEditedRepositoryVisibility.Internal,
                "private" => WebhookTeamEditedRepositoryVisibility.Private,
                "public" => WebhookTeamEditedRepositoryVisibility.Public,
                _ => null,
            };
        }
    }
}