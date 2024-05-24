//HintName: G.Models.InteractionLimitExpiry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The duration of the interaction restriction. Default: `one_day`.
    /// <br/>Example: one_month
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InteractionLimitExpiry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="one_day")]
        OneDay,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="three_days")]
        ThreeDays,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="one_week")]
        OneWeek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="one_month")]
        OneMonth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="six_months")]
        SixMonths,
    }
}