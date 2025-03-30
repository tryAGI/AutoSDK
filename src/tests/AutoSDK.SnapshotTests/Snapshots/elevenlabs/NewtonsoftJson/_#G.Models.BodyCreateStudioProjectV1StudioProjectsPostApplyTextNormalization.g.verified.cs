//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    ///     This parameter controls text normalization with four modes: 'auto', 'on', 'apply_english' and 'off'.<br/>
    ///     When set to 'auto', the system will automatically decide whether to apply text normalization<br/>
    ///     (e.g., spelling out numbers). With 'on', text normalization will always be applied, while<br/>
    ///     with 'off', it will be skipped. 'apply_english' is the same as 'on' but will assume that text is in English.<br/>
    ///     
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization
    {
        /// <summary>
        /// 'auto', 'on', 'apply_english' and 'off'.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 'auto', 'on', 'apply_english' and 'off'.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="on")]
        On,
        /// <summary>
        /// 'auto', 'on', 'apply_english' and 'off'.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 'auto', 'on', 'apply_english' and 'off'.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="apply_english")]
        ApplyEnglish,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.Auto => "auto",
                BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.On => "on",
                BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.Off => "off",
                BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.ApplyEnglish => "apply_english",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.Auto,
                "on" => BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.On,
                "off" => BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.Off,
                "apply_english" => BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.ApplyEnglish,
                _ => null,
            };
        }
    }
}