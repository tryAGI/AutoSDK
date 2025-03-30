//HintName: G.Models.BodyAddProjectV1ProjectsAddPostApplyTextNormalization.g.cs

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
    public enum BodyAddProjectV1ProjectsAddPostApplyTextNormalization
    {
        /// <summary>
        /// 'auto', 'on', 'apply_english' and 'off'.
        /// </summary>
        Auto,
        /// <summary>
        /// 'auto', 'on', 'apply_english' and 'off'.
        /// </summary>
        On,
        /// <summary>
        /// 'auto', 'on', 'apply_english' and 'off'.
        /// </summary>
        Off,
        /// <summary>
        /// 'auto', 'on', 'apply_english' and 'off'.
        /// </summary>
        ApplyEnglish,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyAddProjectV1ProjectsAddPostApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAddProjectV1ProjectsAddPostApplyTextNormalization value)
        {
            return value switch
            {
                BodyAddProjectV1ProjectsAddPostApplyTextNormalization.Auto => "auto",
                BodyAddProjectV1ProjectsAddPostApplyTextNormalization.On => "on",
                BodyAddProjectV1ProjectsAddPostApplyTextNormalization.Off => "off",
                BodyAddProjectV1ProjectsAddPostApplyTextNormalization.ApplyEnglish => "apply_english",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAddProjectV1ProjectsAddPostApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BodyAddProjectV1ProjectsAddPostApplyTextNormalization.Auto,
                "on" => BodyAddProjectV1ProjectsAddPostApplyTextNormalization.On,
                "off" => BodyAddProjectV1ProjectsAddPostApplyTextNormalization.Off,
                "apply_english" => BodyAddProjectV1ProjectsAddPostApplyTextNormalization.ApplyEnglish,
                _ => null,
            };
        }
    }
}