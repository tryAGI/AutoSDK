//HintName: G.Models.WebhookProjectsV2ProjectCreatedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectsV2ProjectCreatedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectsV2ProjectCreatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectsV2ProjectCreatedAction value)
        {
            return value switch
            {
                WebhookProjectsV2ProjectCreatedAction.Created => "created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectsV2ProjectCreatedAction ToEnum(string value)
        {
            return value switch
            {
                "created" => WebhookProjectsV2ProjectCreatedAction.Created,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}