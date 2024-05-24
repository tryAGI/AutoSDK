//HintName: G.Models.InteractionLimitExpiry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The duration of the interaction restriction. Default: `one_day`.
    /// <br/>Example: one_month
    /// </summary>
    public abstract class InteractionLimitExpiry
    {
        /// <summary>
        /// 
        /// </summary>
        public const string OneDay = "one_day";
        /// <summary>
        /// 
        /// </summary>
        public const string ThreeDays = "three_days";
        /// <summary>
        /// 
        /// </summary>
        public const string OneWeek = "one_week";
        /// <summary>
        /// 
        /// </summary>
        public const string OneMonth = "one_month";
        /// <summary>
        /// 
        /// </summary>
        public const string SixMonths = "six_months";
    }
}