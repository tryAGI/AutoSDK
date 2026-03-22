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
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        Partner,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Premier,
        /// <summary>
        /// 
        /// </summary>
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