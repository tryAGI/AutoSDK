//HintName: G.Models.DependabotAlertDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason that the alert was dismissed.
    /// </summary>
    public abstract class DependabotAlertDismissedReason
    {
        /// <summary>
        /// 
        /// </summary>
        public const string FixStarted = "fix_started";
        /// <summary>
        /// 
        /// </summary>
        public const string Inaccurate = "inaccurate";
        /// <summary>
        /// 
        /// </summary>
        public const string NoBandwidth = "no_bandwidth";
        /// <summary>
        /// 
        /// </summary>
        public const string NotUsed = "not_used";
        /// <summary>
        /// 
        /// </summary>
        public const string TolerableRisk = "tolerable_risk";
    }
}