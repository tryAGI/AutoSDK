//HintName: G.Models.UserSubscriptionPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enumerates the plan types for the user subscription.<br/>
    ///  - PLAN_FREE: Free plan.<br/>
    ///  - PLAN_PRO: Pro plan.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UserSubscriptionPlan
    {
        /// <summary>
        /// Free plan.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PLAN_FREE")]
        PlanFree,
        /// <summary>
        /// Pro plan.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PLAN_PRO")]
        PlanPro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserSubscriptionPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserSubscriptionPlan value)
        {
            return value switch
            {
                UserSubscriptionPlan.PlanFree => "PLAN_FREE",
                UserSubscriptionPlan.PlanPro => "PLAN_PRO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserSubscriptionPlan? ToEnum(string value)
        {
            return value switch
            {
                "PLAN_FREE" => UserSubscriptionPlan.PlanFree,
                "PLAN_PRO" => UserSubscriptionPlan.PlanPro,
                _ => null,
            };
        }
    }
}