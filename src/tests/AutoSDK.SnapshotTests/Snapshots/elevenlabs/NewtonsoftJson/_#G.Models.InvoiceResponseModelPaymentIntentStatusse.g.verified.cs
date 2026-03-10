//HintName: G.Models.InvoiceResponseModelPaymentIntentStatusse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InvoiceResponseModelPaymentIntentStatusse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="canceled")]
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requires_action")]
        RequiresAction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requires_capture")]
        RequiresCapture,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requires_confirmation")]
        RequiresConfirmation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requires_payment_method")]
        RequiresPaymentMethod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="succeeded")]
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvoiceResponseModelPaymentIntentStatusseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvoiceResponseModelPaymentIntentStatusse value)
        {
            return value switch
            {
                InvoiceResponseModelPaymentIntentStatusse.Canceled => "canceled",
                InvoiceResponseModelPaymentIntentStatusse.Processing => "processing",
                InvoiceResponseModelPaymentIntentStatusse.RequiresAction => "requires_action",
                InvoiceResponseModelPaymentIntentStatusse.RequiresCapture => "requires_capture",
                InvoiceResponseModelPaymentIntentStatusse.RequiresConfirmation => "requires_confirmation",
                InvoiceResponseModelPaymentIntentStatusse.RequiresPaymentMethod => "requires_payment_method",
                InvoiceResponseModelPaymentIntentStatusse.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvoiceResponseModelPaymentIntentStatusse? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => InvoiceResponseModelPaymentIntentStatusse.Canceled,
                "processing" => InvoiceResponseModelPaymentIntentStatusse.Processing,
                "requires_action" => InvoiceResponseModelPaymentIntentStatusse.RequiresAction,
                "requires_capture" => InvoiceResponseModelPaymentIntentStatusse.RequiresCapture,
                "requires_confirmation" => InvoiceResponseModelPaymentIntentStatusse.RequiresConfirmation,
                "requires_payment_method" => InvoiceResponseModelPaymentIntentStatusse.RequiresPaymentMethod,
                "succeeded" => InvoiceResponseModelPaymentIntentStatusse.Succeeded,
                _ => null,
            };
        }
    }
}