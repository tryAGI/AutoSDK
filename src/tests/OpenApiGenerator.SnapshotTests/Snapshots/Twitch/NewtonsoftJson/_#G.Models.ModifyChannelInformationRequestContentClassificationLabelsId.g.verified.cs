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
    [global::System.Runtime.Serialization.DataContract]
    public enum ModifyChannelInformationRequestContentClassificationLabelsId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DrugsIntoxication")]
        DrugsIntoxication,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SexualThemes")]
        SexualThemes,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ViolentGraphic")]
        ViolentGraphic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Gambling")]
        Gambling,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ProfanityVulgarity")]
        ProfanityVulgarity,
    }
}