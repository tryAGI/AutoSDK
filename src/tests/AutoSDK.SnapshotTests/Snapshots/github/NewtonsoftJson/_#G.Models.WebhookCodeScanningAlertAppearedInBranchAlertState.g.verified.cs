//HintName: G.Models.WebhookCodeScanningAlertAppearedInBranchAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertAppearedInBranchAlertState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed")]
        Fixed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertAppearedInBranchAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertAppearedInBranchAlertState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertAppearedInBranchAlertState.Dismissed => "dismissed",
                WebhookCodeScanningAlertAppearedInBranchAlertState.Fixed => "fixed",
                WebhookCodeScanningAlertAppearedInBranchAlertState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertAppearedInBranchAlertState? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => WebhookCodeScanningAlertAppearedInBranchAlertState.Dismissed,
                "fixed" => WebhookCodeScanningAlertAppearedInBranchAlertState.Fixed,
                "open" => WebhookCodeScanningAlertAppearedInBranchAlertState.Open,
                _ => null,
            };
        }
    }
}