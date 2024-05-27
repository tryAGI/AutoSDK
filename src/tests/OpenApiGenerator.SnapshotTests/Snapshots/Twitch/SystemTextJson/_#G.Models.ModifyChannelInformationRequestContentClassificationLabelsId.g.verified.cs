//HintName: G.Models.ModifyChannelInformationRequestContentClassificationLabelsId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ID of the [Content Classification Labels](https://blog.twitch.tv/en/2023/06/20/introducing-content-classification-labels/) that must be added/removed from the channel. Can be one of the following values:  
    ///   
    /// * DrugsIntoxication
    /// * SexualThemes
    /// * ViolentGraphic
    /// * Gambling
    /// * ProfanityVulgarity
    /// </summary>
    public abstract class ModifyChannelInformationRequestContentClassificationLabelsId
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DrugsIntoxication = "DrugsIntoxication";
        /// <summary>
        /// 
        /// </summary>
        public const string SexualThemes = "SexualThemes";
        /// <summary>
        /// 
        /// </summary>
        public const string ViolentGraphic = "ViolentGraphic";
        /// <summary>
        /// 
        /// </summary>
        public const string Gambling = "Gambling";
        /// <summary>
        /// 
        /// </summary>
        public const string ProfanityVulgarity = "ProfanityVulgarity";
    }
}