//HintName: G.Models.WebhookTeamEditedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookTeamEditedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Edited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookTeamEditedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookTeamEditedAction value)
        {
            return value switch
            {
                WebhookTeamEditedAction.Edited => "edited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookTeamEditedAction? ToEnum(string value)
        {
            return value switch
            {
                "edited" => WebhookTeamEditedAction.Edited,
                _ => null,
            };
        }
    }
}