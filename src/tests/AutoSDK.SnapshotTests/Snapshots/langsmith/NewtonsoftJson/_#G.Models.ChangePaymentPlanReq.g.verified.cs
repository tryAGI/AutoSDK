//HintName: G.Models.ChangePaymentPlanReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for payment plans that the user can change to. Developer plans are permanent and enterprise plans will be changed manually.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChangePaymentPlanReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="free")]
        Free,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="partner")]
        Partner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plus")]
        Plus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="premier")]
        Premier,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="startup")]
        Startup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChangePaymentPlanReqExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChangePaymentPlanReq value)
        {
            return value switch
            {
                ChangePaymentPlanReq.Developer => "developer",
                ChangePaymentPlanReq.Disabled => "disabled",
                ChangePaymentPlanReq.Free => "free",
                ChangePaymentPlanReq.Partner => "partner",
                ChangePaymentPlanReq.Plus => "plus",
                ChangePaymentPlanReq.Premier => "premier",
                ChangePaymentPlanReq.Startup => "startup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChangePaymentPlanReq? ToEnum(string value)
        {
            return value switch
            {
                "developer" => ChangePaymentPlanReq.Developer,
                "disabled" => ChangePaymentPlanReq.Disabled,
                "free" => ChangePaymentPlanReq.Free,
                "partner" => ChangePaymentPlanReq.Partner,
                "plus" => ChangePaymentPlanReq.Plus,
                "premier" => ChangePaymentPlanReq.Premier,
                "startup" => ChangePaymentPlanReq.Startup,
                _ => null,
            };
        }
    }
}