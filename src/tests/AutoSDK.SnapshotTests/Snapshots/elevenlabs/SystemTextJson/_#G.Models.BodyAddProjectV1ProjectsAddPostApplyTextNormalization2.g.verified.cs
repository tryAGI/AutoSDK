//HintName: G.Models.BodyAddProjectV1ProjectsAddPostApplyTextNormalization2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyAddProjectV1ProjectsAddPostApplyTextNormalization2
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
    public static class BodyAddProjectV1ProjectsAddPostApplyTextNormalization2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAddProjectV1ProjectsAddPostApplyTextNormalization2 value)
        {
            return value switch
            {
                BodyAddProjectV1ProjectsAddPostApplyTextNormalization2.Auto => "auto",
                BodyAddProjectV1ProjectsAddPostApplyTextNormalization2.On => "on",
                BodyAddProjectV1ProjectsAddPostApplyTextNormalization2.Off => "off",
                BodyAddProjectV1ProjectsAddPostApplyTextNormalization2.ApplyEnglish => "apply_english",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAddProjectV1ProjectsAddPostApplyTextNormalization2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BodyAddProjectV1ProjectsAddPostApplyTextNormalization2.Auto,
                "on" => BodyAddProjectV1ProjectsAddPostApplyTextNormalization2.On,
                "off" => BodyAddProjectV1ProjectsAddPostApplyTextNormalization2.Off,
                "apply_english" => BodyAddProjectV1ProjectsAddPostApplyTextNormalization2.ApplyEnglish,
                _ => null,
            };
        }
    }
}