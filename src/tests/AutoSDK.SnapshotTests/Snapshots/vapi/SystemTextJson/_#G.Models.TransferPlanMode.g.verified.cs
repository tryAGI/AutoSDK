//HintName: G.Models.TransferPlanMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This configures how transfer is executed and the experience of the destination party receiving the call.<br/>
    /// Usage:<br/>
    /// - `blind-transfer`: The assistant forwards the call to the destination without any message or summary.<br/>
    /// - `blind-transfer-add-summary-to-sip-header`: The assistant forwards the call to the destination and adds a SIP header X-Transfer-Summary to the call to include the summary.<br/>
    /// - `warm-transfer-say-message`: The assistant dials the destination, delivers the `message` to the destination party, connects the customer, and leaves the call.<br/>
    /// - `warm-transfer-say-summary`: The assistant dials the destination, provides a summary of the call to the destination party, connects the customer, and leaves the call.<br/>
    /// - `warm-transfer-wait-for-operator-to-speak-first-and-then-say-message`: The assistant dials the destination, waits for the operator to speak, delivers the `message` to the destination party, and then connects the customer.<br/>
    /// - `warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary`: The assistant dials the destination, waits for the operator to speak, provides a summary of the call to the destination party, and then connects the customer.<br/>
    /// - `warm-transfer-twiml`: The assistant dials the destination, executes the twiml instructions on the destination call leg, connects the customer, and leaves the call.<br/>
    /// - `warm-transfer-experimental`: The assistant puts the customer on hold, dials the destination, and if the destination answers (and is human), delivers a message or summary before connecting the customer. If the destination is unreachable or not human (e.g., with voicemail detection), the assistant delivers the `fallbackMessage` to the customer and optionally ends the call.<br/>
    /// @default 'blind-transfer'
    /// </summary>
    public enum TransferPlanMode
    {
        /// <summary>
        /// The assistant forwards the call to the destination without any message or summary.
        /// </summary>
        BlindTransfer,
        /// <summary>
        /// The assistant forwards the call to the destination and adds a SIP header X-Transfer-Summary to the call to include the summary.
        /// </summary>
        BlindTransferAddSummaryToSipHeader,
        /// <summary>
        /// The assistant puts the customer on hold, dials the destination, and if the destination answers (and is human), delivers a message or summary before connecting the customer. If the destination is unreachable or not human (e.g., with voicemail detection), the assistant delivers the `fallbackMessage` to the customer and optionally ends the call.
        /// </summary>
        WarmTransferExperimental,
        /// <summary>
        /// The assistant dials the destination, delivers the `message` to the destination party, connects the customer, and leaves the call.
        /// </summary>
        WarmTransferSayMessage,
        /// <summary>
        /// The assistant dials the destination, provides a summary of the call to the destination party, connects the customer, and leaves the call.
        /// </summary>
        WarmTransferSaySummary,
        /// <summary>
        /// The assistant dials the destination, executes the twiml instructions on the destination call leg, connects the customer, and leaves the call.
        /// </summary>
        WarmTransferTwiml,
        /// <summary>
        /// The assistant dials the destination, waits for the operator to speak, delivers the `message` to the destination party, and then connects the customer.
        /// </summary>
        WarmTransferWaitForOperatorToSpeakFirstAndThenSayMessage,
        /// <summary>
        /// The assistant dials the destination, waits for the operator to speak, provides a summary of the call to the destination party, and then connects the customer.
        /// </summary>
        WarmTransferWaitForOperatorToSpeakFirstAndThenSaySummary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferPlanModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferPlanMode value)
        {
            return value switch
            {
                TransferPlanMode.BlindTransfer => "blind-transfer",
                TransferPlanMode.BlindTransferAddSummaryToSipHeader => "blind-transfer-add-summary-to-sip-header",
                TransferPlanMode.WarmTransferExperimental => "warm-transfer-experimental",
                TransferPlanMode.WarmTransferSayMessage => "warm-transfer-say-message",
                TransferPlanMode.WarmTransferSaySummary => "warm-transfer-say-summary",
                TransferPlanMode.WarmTransferTwiml => "warm-transfer-twiml",
                TransferPlanMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSayMessage => "warm-transfer-wait-for-operator-to-speak-first-and-then-say-message",
                TransferPlanMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSaySummary => "warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferPlanMode? ToEnum(string value)
        {
            return value switch
            {
                "blind-transfer" => TransferPlanMode.BlindTransfer,
                "blind-transfer-add-summary-to-sip-header" => TransferPlanMode.BlindTransferAddSummaryToSipHeader,
                "warm-transfer-experimental" => TransferPlanMode.WarmTransferExperimental,
                "warm-transfer-say-message" => TransferPlanMode.WarmTransferSayMessage,
                "warm-transfer-say-summary" => TransferPlanMode.WarmTransferSaySummary,
                "warm-transfer-twiml" => TransferPlanMode.WarmTransferTwiml,
                "warm-transfer-wait-for-operator-to-speak-first-and-then-say-message" => TransferPlanMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSayMessage,
                "warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary" => TransferPlanMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSaySummary,
                _ => null,
            };
        }
    }
}