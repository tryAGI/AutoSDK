//HintName: G.Models.ILogicalChatPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ILogicalChatPlan
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
    public static class ILogicalChatPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ILogicalChatPlan value)
        {
            return value switch
            {
                ILogicalChatPlan.Advanced => "advanced",
                ILogicalChatPlan.Basic => "basic",
                ILogicalChatPlan.Enterprise => "enterprise",
                ILogicalChatPlan.EnterpriseTrial => "enterprise-trial",
                ILogicalChatPlan.Free => "free",
                ILogicalChatPlan.Lite => "lite",
                ILogicalChatPlan.LiteBigger => "lite_bigger",
                ILogicalChatPlan.Trial => "trial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ILogicalChatPlan? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => ILogicalChatPlan.Advanced,
                "basic" => ILogicalChatPlan.Basic,
                "enterprise" => ILogicalChatPlan.Enterprise,
                "enterprise-trial" => ILogicalChatPlan.EnterpriseTrial,
                "free" => ILogicalChatPlan.Free,
                "lite" => ILogicalChatPlan.Lite,
                "lite_bigger" => ILogicalChatPlan.LiteBigger,
                "trial" => ILogicalChatPlan.Trial,
                _ => null,
            };
        }
    }
}