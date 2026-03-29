//HintName: G.Models.TransferOptionColdTransferColdTransferMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The mode of the cold transfer. If set to `sip_refer`, will use SIP REFER to transfer the call. If set to `sip_invite`, will use SIP INVITE to transfer the call.<br/>
    /// Default Value: sip_invite
    /// </summary>
    public enum TransferOptionColdTransferColdTransferMode
    {
        /// <summary>
        /// 
        /// </summary>
        SipInvite,
        /// <summary>
        /// 
        /// </summary>
        SipRefer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferOptionColdTransferColdTransferModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferOptionColdTransferColdTransferMode value)
        {
            return value switch
            {
                TransferOptionColdTransferColdTransferMode.SipInvite => "sip_invite",
                TransferOptionColdTransferColdTransferMode.SipRefer => "sip_refer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferOptionColdTransferColdTransferMode? ToEnum(string value)
        {
            return value switch
            {
                "sip_invite" => TransferOptionColdTransferColdTransferMode.SipInvite,
                "sip_refer" => TransferOptionColdTransferColdTransferMode.SipRefer,
                _ => null,
            };
        }
    }
}