//HintName: G.Models.SecretScanningAlertWebhookValidity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The token status as of the latest validity check.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretScanningAlertWebhookValidity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inactive")]
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningAlertWebhookValidityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningAlertWebhookValidity value)
        {
            return value switch
            {
                SecretScanningAlertWebhookValidity.Active => "active",
                SecretScanningAlertWebhookValidity.Inactive => "inactive",
                SecretScanningAlertWebhookValidity.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningAlertWebhookValidity? ToEnum(string value)
        {
            return value switch
            {
                "active" => SecretScanningAlertWebhookValidity.Active,
                "inactive" => SecretScanningAlertWebhookValidity.Inactive,
                "unknown" => SecretScanningAlertWebhookValidity.Unknown,
                _ => null,
            };
        }
    }
}