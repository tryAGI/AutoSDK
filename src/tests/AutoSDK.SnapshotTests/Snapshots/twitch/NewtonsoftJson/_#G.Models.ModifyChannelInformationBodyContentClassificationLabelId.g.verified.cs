//HintName: G.Models.ModifyChannelInformationBodyContentClassificationLabelId.g.cs

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
    [global::System.Runtime.Serialization.DataContract]
    public enum ModifyChannelInformationBodyContentClassificationLabelId
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModifyChannelInformationBodyContentClassificationLabelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModifyChannelInformationBodyContentClassificationLabelId value)
        {
            return value switch
            {
                ModifyChannelInformationBodyContentClassificationLabelId.DrugsIntoxication => "DrugsIntoxication",
                ModifyChannelInformationBodyContentClassificationLabelId.SexualThemes => "SexualThemes",
                ModifyChannelInformationBodyContentClassificationLabelId.ViolentGraphic => "ViolentGraphic",
                ModifyChannelInformationBodyContentClassificationLabelId.Gambling => "Gambling",
                ModifyChannelInformationBodyContentClassificationLabelId.ProfanityVulgarity => "ProfanityVulgarity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModifyChannelInformationBodyContentClassificationLabelId? ToEnum(string value)
        {
            return value switch
            {
                "DrugsIntoxication" => ModifyChannelInformationBodyContentClassificationLabelId.DrugsIntoxication,
                "SexualThemes" => ModifyChannelInformationBodyContentClassificationLabelId.SexualThemes,
                "ViolentGraphic" => ModifyChannelInformationBodyContentClassificationLabelId.ViolentGraphic,
                "Gambling" => ModifyChannelInformationBodyContentClassificationLabelId.Gambling,
                "ProfanityVulgarity" => ModifyChannelInformationBodyContentClassificationLabelId.ProfanityVulgarity,
                _ => null,
            };
        }
    }
}