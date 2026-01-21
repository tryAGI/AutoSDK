//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="on")]
        On,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="apply_english")]
        ApplyEnglish,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2 value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2.Auto => "auto",
                BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2.On => "on",
                BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2.Off => "off",
                BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2.ApplyEnglish => "apply_english",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2.Auto,
                "on" => BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2.On,
                "off" => BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2.Off,
                "apply_english" => BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2.ApplyEnglish,
                _ => null,
            };
        }
    }
}