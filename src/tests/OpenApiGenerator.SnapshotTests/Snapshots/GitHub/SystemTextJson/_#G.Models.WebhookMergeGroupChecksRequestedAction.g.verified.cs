//HintName: G.Models.WebhookMergeGroupChecksRequestedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMergeGroupChecksRequestedAction
    {
        /// <summary>
        /// 
        /// </summary>
        ChecksRequested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMergeGroupChecksRequestedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMergeGroupChecksRequestedAction value)
        {
            return value switch
            {
                WebhookMergeGroupChecksRequestedAction.ChecksRequested => "checks_requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMergeGroupChecksRequestedAction ToEnum(string value)
        {
            return value switch
            {
                "checks_requested" => WebhookMergeGroupChecksRequestedAction.ChecksRequested,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}