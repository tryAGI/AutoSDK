//HintName: G.Models.WebhookRepositoryPublicizedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookRepositoryPublicizedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Publicized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRepositoryPublicizedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRepositoryPublicizedAction value)
        {
            return value switch
            {
                WebhookRepositoryPublicizedAction.Publicized => "publicized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRepositoryPublicizedAction? ToEnum(string value)
        {
            return value switch
            {
                "publicized" => WebhookRepositoryPublicizedAction.Publicized,
                _ => null,
            };
        }
    }
}