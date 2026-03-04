//HintName: G.Models.OrganizationSubscriptionPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enumerates the plan types for the organization subscription.<br/>
    ///  - PLAN_FREE: Free plan.<br/>
    ///  - PLAN_TEAM: Team plan.<br/>
    ///  - PLAN_ENTERPRISE: Enterprise plan.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrganizationSubscriptionPlan
    {
        /// <summary>
        /// Free plan.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PLAN_FREE")]
        PlanFree,
        /// <summary>
        /// Team plan.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PLAN_TEAM")]
        PlanTeam,
        /// <summary>
        /// Enterprise plan.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PLAN_ENTERPRISE")]
        PlanEnterprise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationSubscriptionPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationSubscriptionPlan value)
        {
            return value switch
            {
                OrganizationSubscriptionPlan.PlanFree => "PLAN_FREE",
                OrganizationSubscriptionPlan.PlanTeam => "PLAN_TEAM",
                OrganizationSubscriptionPlan.PlanEnterprise => "PLAN_ENTERPRISE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationSubscriptionPlan? ToEnum(string value)
        {
            return value switch
            {
                "PLAN_FREE" => OrganizationSubscriptionPlan.PlanFree,
                "PLAN_TEAM" => OrganizationSubscriptionPlan.PlanTeam,
                "PLAN_ENTERPRISE" => OrganizationSubscriptionPlan.PlanEnterprise,
                _ => null,
            };
        }
    }
}