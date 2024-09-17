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
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PLAN_FREE")]
        PLANFREE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PLAN_TEAM")]
        PLANTEAM,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PLAN_ENTERPRISE")]
        PLANENTERPRISE,
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
                OrganizationSubscriptionPlan.PLANFREE => "PLAN_FREE",
                OrganizationSubscriptionPlan.PLANTEAM => "PLAN_TEAM",
                OrganizationSubscriptionPlan.PLANENTERPRISE => "PLAN_ENTERPRISE",
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
                "PLAN_FREE" => OrganizationSubscriptionPlan.PLANFREE,
                "PLAN_TEAM" => OrganizationSubscriptionPlan.PLANTEAM,
                "PLAN_ENTERPRISE" => OrganizationSubscriptionPlan.PLANENTERPRISE,
                _ => null,
            };
        }
    }
}