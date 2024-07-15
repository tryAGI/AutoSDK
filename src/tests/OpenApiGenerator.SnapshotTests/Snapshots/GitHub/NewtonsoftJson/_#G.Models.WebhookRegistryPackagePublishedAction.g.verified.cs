//HintName: G.Models.WebhookRegistryPackagePublishedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookRegistryPackagePublishedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="published")]
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRegistryPackagePublishedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRegistryPackagePublishedAction value)
        {
            return value switch
            {
                WebhookRegistryPackagePublishedAction.Published => "published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRegistryPackagePublishedAction? ToEnum(string value)
        {
            return value switch
            {
                "published" => WebhookRegistryPackagePublishedAction.Published,
                _ => null,
            };
        }
    }
}