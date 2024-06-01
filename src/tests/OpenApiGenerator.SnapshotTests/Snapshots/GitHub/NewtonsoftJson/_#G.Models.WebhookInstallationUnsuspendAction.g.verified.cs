//HintName: G.Models.WebhookInstallationUnsuspendAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookInstallationUnsuspendAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unsuspend")]
        Unsuspend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookInstallationUnsuspendActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookInstallationUnsuspendAction value)
        {
            return value switch
            {
                WebhookInstallationUnsuspendAction.Unsuspend => "unsuspend",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookInstallationUnsuspendAction ToEnum(string value)
        {
            return value switch
            {
                "unsuspend" => WebhookInstallationUnsuspendAction.Unsuspend,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}