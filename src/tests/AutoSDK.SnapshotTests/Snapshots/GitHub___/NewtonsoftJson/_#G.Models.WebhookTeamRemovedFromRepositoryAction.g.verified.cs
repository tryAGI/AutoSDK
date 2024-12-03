//HintName: G.Models.WebhookTeamRemovedFromRepositoryAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookTeamRemovedFromRepositoryAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="removed_from_repository")]
        RemovedFromRepository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookTeamRemovedFromRepositoryActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamRemovedFromRepositoryAction value)
        {
            return value switch
            {
                WebhookTeamRemovedFromRepositoryAction.RemovedFromRepository => "removed_from_repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamRemovedFromRepositoryAction? ToEnum(string value)
        {
            return value switch
            {
                "removed_from_repository" => WebhookTeamRemovedFromRepositoryAction.RemovedFromRepository,
                _ => null,
            };
        }
    }
}