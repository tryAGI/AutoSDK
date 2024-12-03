//HintName: G.Models.WebhookTeamRemovedFromRepositoryRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookTeamRemovedFromRepositoryRepositoryVisibility
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
    public static class WebhookTeamRemovedFromRepositoryRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamRemovedFromRepositoryRepositoryVisibility value)
        {
            return value switch
            {
                WebhookTeamRemovedFromRepositoryRepositoryVisibility.Public => "public",
                WebhookTeamRemovedFromRepositoryRepositoryVisibility.Private => "private",
                WebhookTeamRemovedFromRepositoryRepositoryVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamRemovedFromRepositoryRepositoryVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookTeamRemovedFromRepositoryRepositoryVisibility.Public,
                "private" => WebhookTeamRemovedFromRepositoryRepositoryVisibility.Private,
                "internal" => WebhookTeamRemovedFromRepositoryRepositoryVisibility.Internal,
                _ => null,
            };
        }
    }
}