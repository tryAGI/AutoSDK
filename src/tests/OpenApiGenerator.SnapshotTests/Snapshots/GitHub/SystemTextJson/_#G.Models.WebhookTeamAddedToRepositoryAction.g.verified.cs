//HintName: G.Models.WebhookTeamAddedToRepositoryAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookTeamAddedToRepositoryAction
    {
        /// <summary>
        /// 
        /// </summary>
        AddedToRepository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookTeamAddedToRepositoryActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamAddedToRepositoryAction value)
        {
            return value switch
            {
                WebhookTeamAddedToRepositoryAction.AddedToRepository => "added_to_repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamAddedToRepositoryAction? ToEnum(string value)
        {
            return value switch
            {
                "added_to_repository" => WebhookTeamAddedToRepositoryAction.AddedToRepository,
                _ => null,
            };
        }
    }
}