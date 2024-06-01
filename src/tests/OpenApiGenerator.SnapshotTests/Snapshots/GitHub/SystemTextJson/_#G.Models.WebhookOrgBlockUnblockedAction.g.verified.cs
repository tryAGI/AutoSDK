//HintName: G.Models.WebhookOrgBlockUnblockedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookOrgBlockUnblockedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Unblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookOrgBlockUnblockedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookOrgBlockUnblockedAction value)
        {
            return value switch
            {
                WebhookOrgBlockUnblockedAction.Unblocked => "unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookOrgBlockUnblockedAction ToEnum(string value)
        {
            return value switch
            {
                "unblocked" => WebhookOrgBlockUnblockedAction.Unblocked,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}