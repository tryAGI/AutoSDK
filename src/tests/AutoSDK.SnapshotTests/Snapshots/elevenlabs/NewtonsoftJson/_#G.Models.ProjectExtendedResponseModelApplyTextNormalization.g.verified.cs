//HintName: G.Models.ProjectExtendedResponseModelApplyTextNormalization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether text normalization is applied to the project.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectExtendedResponseModelApplyTextNormalization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="apply_english")]
        ApplyEnglish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="on")]
        On,
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
                ProjectExtendedResponseModelApplyTextNormalization.ApplyEnglish => "apply_english",
                ProjectExtendedResponseModelApplyTextNormalization.Auto => "auto",
                ProjectExtendedResponseModelApplyTextNormalization.Off => "off",
                ProjectExtendedResponseModelApplyTextNormalization.On => "on",
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
                "apply_english" => ProjectExtendedResponseModelApplyTextNormalization.ApplyEnglish,
                "auto" => ProjectExtendedResponseModelApplyTextNormalization.Auto,
                "off" => ProjectExtendedResponseModelApplyTextNormalization.Off,
                "on" => ProjectExtendedResponseModelApplyTextNormalization.On,
                _ => null,
            };
        }
    }
}