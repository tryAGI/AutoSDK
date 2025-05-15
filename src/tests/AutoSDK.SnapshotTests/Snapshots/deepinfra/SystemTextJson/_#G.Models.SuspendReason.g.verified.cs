//HintName: G.Models.SuspendReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SuspendReason
    {
        /// <summary>
        /// 
        /// </summary>
        PaymentMethod,
        /// <summary>
        /// 
        /// </summary>
        OverdueInvoices,
        /// <summary>
        /// 
        /// </summary>
        LimitReached,
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        BadCc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SuspendReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SuspendReason value)
        {
            return value switch
            {
                SuspendReason.PaymentMethod => "payment-method",
                SuspendReason.OverdueInvoices => "overdue-invoices",
                SuspendReason.LimitReached => "limit-reached",
                SuspendReason.Admin => "admin",
                SuspendReason.BadCc => "bad-cc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SuspendReason? ToEnum(string value)
        {
            return value switch
            {
                "payment-method" => SuspendReason.PaymentMethod,
                "overdue-invoices" => SuspendReason.OverdueInvoices,
                "limit-reached" => SuspendReason.LimitReached,
                "admin" => SuspendReason.Admin,
                "bad-cc" => SuspendReason.BadCc,
                _ => null,
            };
        }
    }
}