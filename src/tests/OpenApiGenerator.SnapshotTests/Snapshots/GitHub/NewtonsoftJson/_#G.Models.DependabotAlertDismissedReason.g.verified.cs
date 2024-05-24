//HintName: G.Models.DependabotAlertDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason that the alert was dismissed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotAlertDismissedReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fix_started")]
        FixStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inaccurate")]
        Inaccurate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no_bandwidth")]
        NoBandwidth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_used")]
        NotUsed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tolerable_risk")]
        TolerableRisk,
    }
}