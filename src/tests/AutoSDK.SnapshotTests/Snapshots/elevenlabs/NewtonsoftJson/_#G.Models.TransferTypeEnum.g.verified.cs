//HintName: G.Models.TransferTypeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blind")]
        Blind,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conference")]
        Conference,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sip_refer")]
        SipRefer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferTypeEnum value)
        {
            return value switch
            {
                TransferTypeEnum.Blind => "blind",
                TransferTypeEnum.Conference => "conference",
                TransferTypeEnum.SipRefer => "sip_refer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "blind" => TransferTypeEnum.Blind,
                "conference" => TransferTypeEnum.Conference,
                "sip_refer" => TransferTypeEnum.SipRefer,
                _ => null,
            };
        }
    }
}