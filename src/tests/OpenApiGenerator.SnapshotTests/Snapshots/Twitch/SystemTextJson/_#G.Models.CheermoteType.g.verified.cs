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
    public abstract class CheermoteType
    {
        /// <summary>
        /// 
        /// </summary>
        public const string GlobalFirstParty = "global_first_party";
        /// <summary>
        /// 
        /// </summary>
        public const string GlobalThirdParty = "global_third_party";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelCustom = "channel_custom";
        /// <summary>
        /// 
        /// </summary>
        public const string DisplayOnly = "display_only";
        /// <summary>
        /// 
        /// </summary>
        public const string Sponsored = "sponsored";
    }
}