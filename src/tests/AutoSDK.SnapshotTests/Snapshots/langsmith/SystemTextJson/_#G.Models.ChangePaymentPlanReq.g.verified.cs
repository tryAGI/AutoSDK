//HintName: G.Models.ChangePaymentPlanReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for payment plans that the user can change to. Developer plans are permanent and enterprise plans will be changed manually.
    /// </summary>
    public enum ChangePaymentPlanReq
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Startup,
        /// <summary>
        /// 
        /// </summary>
        Partner,
        /// <summary>
        /// 
        /// </summary>
        Premier,
        /// <summary>
        /// 
        /// </summary>
        Free,
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
                ChangePaymentPlanReq.Disabled => "disabled",
                ChangePaymentPlanReq.Developer => "developer",
                ChangePaymentPlanReq.Plus => "plus",
                ChangePaymentPlanReq.Startup => "startup",
                ChangePaymentPlanReq.Partner => "partner",
                ChangePaymentPlanReq.Premier => "premier",
                ChangePaymentPlanReq.Free => "free",
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
                "disabled" => ChangePaymentPlanReq.Disabled,
                "developer" => ChangePaymentPlanReq.Developer,
                "plus" => ChangePaymentPlanReq.Plus,
                "startup" => ChangePaymentPlanReq.Startup,
                "partner" => ChangePaymentPlanReq.Partner,
                "premier" => ChangePaymentPlanReq.Premier,
                "free" => ChangePaymentPlanReq.Free,
                _ => null,
            };
        }
    }
}