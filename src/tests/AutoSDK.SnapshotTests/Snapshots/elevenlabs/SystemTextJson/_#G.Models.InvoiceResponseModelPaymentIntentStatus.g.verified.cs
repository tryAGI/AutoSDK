//HintName: G.Models.InvoiceResponseModelPaymentIntentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InvoiceResponseModelPaymentIntentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        RequiresAction,
        /// <summary>
        /// 
        /// </summary>
        RequiresCapture,
        /// <summary>
        /// 
        /// </summary>
        RequiresConfirmation,
        /// <summary>
        /// 
        /// </summary>
        RequiresPaymentMethod,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvoiceResponseModelPaymentIntentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvoiceResponseModelPaymentIntentStatus value)
        {
            return value switch
            {
                InvoiceResponseModelPaymentIntentStatus.Canceled => "canceled",
                InvoiceResponseModelPaymentIntentStatus.Processing => "processing",
                InvoiceResponseModelPaymentIntentStatus.RequiresAction => "requires_action",
                InvoiceResponseModelPaymentIntentStatus.RequiresCapture => "requires_capture",
                InvoiceResponseModelPaymentIntentStatus.RequiresConfirmation => "requires_confirmation",
                InvoiceResponseModelPaymentIntentStatus.RequiresPaymentMethod => "requires_payment_method",
                InvoiceResponseModelPaymentIntentStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvoiceResponseModelPaymentIntentStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => InvoiceResponseModelPaymentIntentStatus.Canceled,
                "processing" => InvoiceResponseModelPaymentIntentStatus.Processing,
                "requires_action" => InvoiceResponseModelPaymentIntentStatus.RequiresAction,
                "requires_capture" => InvoiceResponseModelPaymentIntentStatus.RequiresCapture,
                "requires_confirmation" => InvoiceResponseModelPaymentIntentStatus.RequiresConfirmation,
                "requires_payment_method" => InvoiceResponseModelPaymentIntentStatus.RequiresPaymentMethod,
                "succeeded" => InvoiceResponseModelPaymentIntentStatus.Succeeded,
                _ => null,
            };
        }
    }
}