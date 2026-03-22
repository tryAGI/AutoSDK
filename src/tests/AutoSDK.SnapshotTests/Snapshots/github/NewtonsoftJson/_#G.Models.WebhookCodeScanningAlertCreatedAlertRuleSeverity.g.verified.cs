//HintName: G.Models.WebhookCodeScanningAlertCreatedAlertRuleSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertCreatedAlertRuleSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="note")]
        Note,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="warning")]
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertCreatedAlertRuleSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertCreatedAlertRuleSeverity value)
        {
            return value switch
            {
                WebhookCodeScanningAlertCreatedAlertRuleSeverity.Error => "error",
                WebhookCodeScanningAlertCreatedAlertRuleSeverity.None => "none",
                WebhookCodeScanningAlertCreatedAlertRuleSeverity.Note => "note",
                WebhookCodeScanningAlertCreatedAlertRuleSeverity.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCodeScanningAlertCreatedAlertRuleSeverity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertCreatedAlertRuleSeverity? ToEnum(string value)
        {
            return value switch
            {
                "error" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.Error,
                "none" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.Note,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "warning" => WebhookCodeScanningAlertCreatedAlertRuleSeverity.Warning,
                _ => null,
            };
        }
    }
}