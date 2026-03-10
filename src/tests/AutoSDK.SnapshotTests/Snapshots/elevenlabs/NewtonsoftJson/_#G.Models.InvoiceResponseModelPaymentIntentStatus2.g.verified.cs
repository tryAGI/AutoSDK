//HintName: G.Models.InvoiceResponseModelPaymentIntentStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InvoiceResponseModelPaymentIntentStatus2
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
    public static class InvoiceResponseModelPaymentIntentStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvoiceResponseModelPaymentIntentStatus2 value)
        {
            return value switch
            {
                InvoiceResponseModelPaymentIntentStatus2.Canceled => "canceled",
                InvoiceResponseModelPaymentIntentStatus2.Processing => "processing",
                InvoiceResponseModelPaymentIntentStatus2.RequiresAction => "requires_action",
                InvoiceResponseModelPaymentIntentStatus2.RequiresCapture => "requires_capture",
                InvoiceResponseModelPaymentIntentStatus2.RequiresConfirmation => "requires_confirmation",
                InvoiceResponseModelPaymentIntentStatus2.RequiresPaymentMethod => "requires_payment_method",
                InvoiceResponseModelPaymentIntentStatus2.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvoiceResponseModelPaymentIntentStatus2? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => InvoiceResponseModelPaymentIntentStatus2.Canceled,
                "processing" => InvoiceResponseModelPaymentIntentStatus2.Processing,
                "requires_action" => InvoiceResponseModelPaymentIntentStatus2.RequiresAction,
                "requires_capture" => InvoiceResponseModelPaymentIntentStatus2.RequiresCapture,
                "requires_confirmation" => InvoiceResponseModelPaymentIntentStatus2.RequiresConfirmation,
                "requires_payment_method" => InvoiceResponseModelPaymentIntentStatus2.RequiresPaymentMethod,
                "succeeded" => InvoiceResponseModelPaymentIntentStatus2.Succeeded,
                _ => null,
            };
        }
    }
}