//HintName: G.Models.SuspendReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SuspendReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="payment-method")]
        PaymentMethod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="overdue-invoices")]
        OverdueInvoices,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="limit-reached")]
        LimitReached,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bad-cc")]
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