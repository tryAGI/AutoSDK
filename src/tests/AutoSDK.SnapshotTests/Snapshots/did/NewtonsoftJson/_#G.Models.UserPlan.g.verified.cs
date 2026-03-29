//HintName: G.Models.UserPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UserPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="advanced")]
        Advanced,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enterprise")]
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enterprise-trial")]
        EnterpriseTrial,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="free")]
        Free,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lite")]
        Lite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lite_bigger")]
        LiteBigger,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trial")]
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