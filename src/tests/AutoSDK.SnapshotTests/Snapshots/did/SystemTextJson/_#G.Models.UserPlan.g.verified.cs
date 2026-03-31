//HintName: G.Models.UserPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Advanced,
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseTrial,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        Lite,
        /// <summary>
        /// 
        /// </summary>
        LiteBigger,
        /// <summary>
        /// 
        /// </summary>
        Trial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserPlan value)
        {
            return value switch
            {
                UserPlan.Advanced => "advanced",
                UserPlan.Basic => "basic",
                UserPlan.Enterprise => "enterprise",
                UserPlan.EnterpriseTrial => "enterprise-trial",
                UserPlan.Free => "free",
                UserPlan.Lite => "lite",
                UserPlan.LiteBigger => "lite_bigger",
                UserPlan.Trial => "trial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserPlan? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => UserPlan.Advanced,
                "basic" => UserPlan.Basic,
                "enterprise" => UserPlan.Enterprise,
                "enterprise-trial" => UserPlan.EnterpriseTrial,
                "free" => UserPlan.Free,
                "lite" => UserPlan.Lite,
                "lite_bigger" => UserPlan.LiteBigger,
                "trial" => UserPlan.Trial,
                _ => null,
            };
        }
    }
}