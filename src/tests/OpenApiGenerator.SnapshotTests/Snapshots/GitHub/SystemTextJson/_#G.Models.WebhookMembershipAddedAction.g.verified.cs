//HintName: G.Models.WebhookMembershipAddedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMembershipAddedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Added,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMembershipAddedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMembershipAddedAction value)
        {
            return value switch
            {
                WebhookMembershipAddedAction.Added => "added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMembershipAddedAction ToEnum(string value)
        {
            return value switch
            {
                "added" => WebhookMembershipAddedAction.Added,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}