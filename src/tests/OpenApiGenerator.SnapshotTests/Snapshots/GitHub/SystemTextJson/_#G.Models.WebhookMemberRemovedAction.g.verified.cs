//HintName: G.Models.WebhookMemberRemovedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMemberRemovedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Removed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMemberRemovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMemberRemovedAction value)
        {
            return value switch
            {
                WebhookMemberRemovedAction.Removed => "removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMemberRemovedAction? ToEnum(string value)
        {
            return value switch
            {
                "removed" => WebhookMemberRemovedAction.Removed,
                _ => null,
            };
        }
    }
}