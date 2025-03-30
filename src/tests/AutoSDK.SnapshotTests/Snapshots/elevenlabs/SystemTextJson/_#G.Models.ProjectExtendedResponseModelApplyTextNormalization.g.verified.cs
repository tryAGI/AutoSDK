//HintName: G.Models.ProjectExtendedResponseModelApplyTextNormalization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether text normalization is applied to the project.
    /// </summary>
    public enum ProjectExtendedResponseModelApplyTextNormalization
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        On,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        ApplyEnglish,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectExtendedResponseModelApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelApplyTextNormalization value)
        {
            return value switch
            {
                ProjectExtendedResponseModelApplyTextNormalization.Auto => "auto",
                ProjectExtendedResponseModelApplyTextNormalization.On => "on",
                ProjectExtendedResponseModelApplyTextNormalization.Off => "off",
                ProjectExtendedResponseModelApplyTextNormalization.ApplyEnglish => "apply_english",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ProjectExtendedResponseModelApplyTextNormalization.Auto,
                "on" => ProjectExtendedResponseModelApplyTextNormalization.On,
                "off" => ProjectExtendedResponseModelApplyTextNormalization.Off,
                "apply_english" => ProjectExtendedResponseModelApplyTextNormalization.ApplyEnglish,
                _ => null,
            };
        }
    }
}