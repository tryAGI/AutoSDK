//HintName: G.Models.WebhookInstallationNewPermissionsAcceptedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookInstallationNewPermissionsAcceptedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="new_permissions_accepted")]
        NewPermissionsAccepted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookInstallationNewPermissionsAcceptedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookInstallationNewPermissionsAcceptedAction value)
        {
            return value switch
            {
                WebhookInstallationNewPermissionsAcceptedAction.NewPermissionsAccepted => "new_permissions_accepted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookInstallationNewPermissionsAcceptedAction? ToEnum(string value)
        {
            return value switch
            {
                "new_permissions_accepted" => WebhookInstallationNewPermissionsAcceptedAction.NewPermissionsAccepted,
                _ => null,
            };
        }
    }
}