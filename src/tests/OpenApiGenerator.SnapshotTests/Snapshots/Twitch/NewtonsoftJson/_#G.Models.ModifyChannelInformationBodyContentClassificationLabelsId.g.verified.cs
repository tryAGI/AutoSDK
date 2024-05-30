//HintName: G.Models.ModifyChannelInformationBodyContentClassificationLabelsId.g.cs

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
    public enum ModifyChannelInformationBodyContentClassificationLabelsId
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

    public static class ModifyChannelInformationBodyContentClassificationLabelsIdExtensions
    {
        public static string ToValueString(this ModifyChannelInformationBodyContentClassificationLabelsId value)
        {
            return value switch
            {
                ModifyChannelInformationBodyContentClassificationLabelsId.DrugsIntoxication => "DrugsIntoxication",
                ModifyChannelInformationBodyContentClassificationLabelsId.SexualThemes => "SexualThemes",
                ModifyChannelInformationBodyContentClassificationLabelsId.ViolentGraphic => "ViolentGraphic",
                ModifyChannelInformationBodyContentClassificationLabelsId.Gambling => "Gambling",
                ModifyChannelInformationBodyContentClassificationLabelsId.ProfanityVulgarity => "ProfanityVulgarity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ModifyChannelInformationBodyContentClassificationLabelsId ToEnum(string value)
        {
            return value switch
            {
                "DrugsIntoxication" => ModifyChannelInformationBodyContentClassificationLabelsId.DrugsIntoxication,
                "SexualThemes" => ModifyChannelInformationBodyContentClassificationLabelsId.SexualThemes,
                "ViolentGraphic" => ModifyChannelInformationBodyContentClassificationLabelsId.ViolentGraphic,
                "Gambling" => ModifyChannelInformationBodyContentClassificationLabelsId.Gambling,
                "ProfanityVulgarity" => ModifyChannelInformationBodyContentClassificationLabelsId.ProfanityVulgarity,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ModifyChannelInformationBodyContentClassificationLabelsId ToEnum(int value)
        {
            return value switch
            {
                0 => ModifyChannelInformationBodyContentClassificationLabelsId.DrugsIntoxication,
                1 => ModifyChannelInformationBodyContentClassificationLabelsId.SexualThemes,
                2 => ModifyChannelInformationBodyContentClassificationLabelsId.ViolentGraphic,
                3 => ModifyChannelInformationBodyContentClassificationLabelsId.Gambling,
                4 => ModifyChannelInformationBodyContentClassificationLabelsId.ProfanityVulgarity,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}