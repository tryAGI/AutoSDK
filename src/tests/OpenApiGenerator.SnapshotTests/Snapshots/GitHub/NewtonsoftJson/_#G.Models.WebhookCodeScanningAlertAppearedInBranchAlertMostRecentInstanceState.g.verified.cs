//HintName: G.Models.WebhookCodeScanningAlertAppearedInBranchAlertMostRecentInstanceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCodeScanningAlertAppearedInBranchAlertMostRecentInstanceState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertAppearedInBranchAlertMostRecentInstanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertAppearedInBranchAlertMostRecentInstanceState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertAppearedInBranchAlertMostRecentInstanceState.Open => "open",
                WebhookCodeScanningAlertAppearedInBranchAlertMostRecentInstanceState.Dismissed => "dismissed",
                WebhookCodeScanningAlertAppearedInBranchAlertMostRecentInstanceState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertAppearedInBranchAlertMostRecentInstanceState ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookCodeScanningAlertAppearedInBranchAlertMostRecentInstanceState.Open,
                "dismissed" => WebhookCodeScanningAlertAppearedInBranchAlertMostRecentInstanceState.Dismissed,
                "fixed" => WebhookCodeScanningAlertAppearedInBranchAlertMostRecentInstanceState.Fixed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}