//HintName: G.Models.WebhookReleaseUnpublishedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookReleaseUnpublishedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unpublished")]
        Unpublished,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookReleaseUnpublishedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookReleaseUnpublishedAction value)
        {
            return value switch
            {
                WebhookReleaseUnpublishedAction.Unpublished => "unpublished",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookReleaseUnpublishedAction ToEnum(string value)
        {
            return value switch
            {
                "unpublished" => WebhookReleaseUnpublishedAction.Unpublished,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}