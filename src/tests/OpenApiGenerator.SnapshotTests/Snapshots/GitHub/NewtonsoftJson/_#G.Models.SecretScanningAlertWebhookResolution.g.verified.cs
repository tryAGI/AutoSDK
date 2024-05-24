//HintName: G.Models.SecretScanningAlertWebhookResolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for resolving the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretScanningAlertWebhookResolution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="false_positive")]
        FalsePositive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wont_fix")]
        WontFix,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="revoked")]
        Revoked,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="used_in_tests")]
        UsedInTests,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pattern_deleted")]
        PatternDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pattern_edited")]
        PatternEdited,
    }
}