//HintName: G.Models.WebhookRepositoryPrivatizedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookRepositoryPrivatizedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Privatized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRepositoryPrivatizedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRepositoryPrivatizedAction value)
        {
            return value switch
            {
                WebhookRepositoryPrivatizedAction.Privatized => "privatized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRepositoryPrivatizedAction? ToEnum(string value)
        {
            return value switch
            {
                "privatized" => WebhookRepositoryPrivatizedAction.Privatized,
                _ => null,
            };
        }
    }
}