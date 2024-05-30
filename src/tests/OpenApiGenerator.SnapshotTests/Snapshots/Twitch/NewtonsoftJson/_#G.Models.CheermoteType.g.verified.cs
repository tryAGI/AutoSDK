//HintName: G.Models.CheermoteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of Cheermote. Possible values are:  
    ///   
    /// * global\_first\_party — A Twitch-defined Cheermote that is shown in the Bits card.
    /// * global\_third\_party — A Twitch-defined Cheermote that is not shown in the Bits card.
    /// * channel\_custom — A broadcaster-defined Cheermote.
    /// * display\_only — Do not use; for internal use only.
    /// * sponsored — A sponsor-defined Cheermote. When used, the sponsor adds additional Bits to the amount that the user cheered. For example, if the user cheered Terminator100, the broadcaster might receive 110 Bits, which includes the sponsor's 10 Bits contribution.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CheermoteType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="global_first_party")]
        GlobalFirstParty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="global_third_party")]
        GlobalThirdParty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel_custom")]
        ChannelCustom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="display_only")]
        DisplayOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sponsored")]
        Sponsored,
    }

    public static class CheermoteTypeExtensions
    {
        public static string ToValueString(this CheermoteType value)
        {
            return value switch
            {
                CheermoteType.GlobalFirstParty => "global_first_party",
                CheermoteType.GlobalThirdParty => "global_third_party",
                CheermoteType.ChannelCustom => "channel_custom",
                CheermoteType.DisplayOnly => "display_only",
                CheermoteType.Sponsored => "sponsored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CheermoteType ToEnum(string value)
        {
            return value switch
            {
                "global_first_party" => CheermoteType.GlobalFirstParty,
                "global_third_party" => CheermoteType.GlobalThirdParty,
                "channel_custom" => CheermoteType.ChannelCustom,
                "display_only" => CheermoteType.DisplayOnly,
                "sponsored" => CheermoteType.Sponsored,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CheermoteType ToEnum(int value)
        {
            return value switch
            {
                0 => CheermoteType.GlobalFirstParty,
                1 => CheermoteType.GlobalThirdParty,
                2 => CheermoteType.ChannelCustom,
                3 => CheermoteType.DisplayOnly,
                4 => CheermoteType.Sponsored,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}