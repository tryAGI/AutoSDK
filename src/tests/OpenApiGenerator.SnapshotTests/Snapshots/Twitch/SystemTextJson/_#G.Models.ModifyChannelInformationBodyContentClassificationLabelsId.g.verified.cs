//HintName: G.Models.ModifyChannelInformationBodyContentClassificationLabelsId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ID of the [Content Classification Labels](https://blog.twitch.tv/en/2023/06/20/introducing-content-classification-labels/) that must be added/removed from the channel. Can be one of the following values:  <br/>
    ///   <br/>
    /// * DrugsIntoxication<br/>
    /// * SexualThemes<br/>
    /// * ViolentGraphic<br/>
    /// * Gambling<br/>
    /// * ProfanityVulgarity
    /// </summary>
    public enum ModifyChannelInformationBodyContentClassificationLabelsId
    {
        /// <summary>
        /// 
        /// </summary>
        DrugsIntoxication,
        /// <summary>
        /// 
        /// </summary>
        SexualThemes,
        /// <summary>
        /// 
        /// </summary>
        ViolentGraphic,
        /// <summary>
        /// 
        /// </summary>
        Gambling,
        /// <summary>
        /// 
        /// </summary>
        ProfanityVulgarity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModifyChannelInformationBodyContentClassificationLabelsIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModifyChannelInformationBodyContentClassificationLabelsId? ToEnum(string value)
        {
            return value switch
            {
                "DrugsIntoxication" => ModifyChannelInformationBodyContentClassificationLabelsId.DrugsIntoxication,
                "SexualThemes" => ModifyChannelInformationBodyContentClassificationLabelsId.SexualThemes,
                "ViolentGraphic" => ModifyChannelInformationBodyContentClassificationLabelsId.ViolentGraphic,
                "Gambling" => ModifyChannelInformationBodyContentClassificationLabelsId.Gambling,
                "ProfanityVulgarity" => ModifyChannelInformationBodyContentClassificationLabelsId.ProfanityVulgarity,
                _ => null,
            };
        }
    }
}