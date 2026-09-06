//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization
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
    public static class BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.ApplyEnglish => "apply_english",
                BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.Auto => "auto",
                BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.Off => "off",
                BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.On => "on",
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
                "apply_english" => BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.ApplyEnglish,
                "auto" => BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.Auto,
                "off" => BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.Off,
                "on" => BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization.On,
                _ => null,
            };
        }
    }
}