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
    public enum CheermoteType
    {
        /// <summary>
        /// 
        /// </summary>
        GlobalFirstParty,
        /// <summary>
        /// 
        /// </summary>
        GlobalThirdParty,
        /// <summary>
        /// 
        /// </summary>
        ChannelCustom,
        /// <summary>
        /// 
        /// </summary>
        DisplayOnly,
        /// <summary>
        /// 
        /// </summary>
        Sponsored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheermoteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
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
    }
}