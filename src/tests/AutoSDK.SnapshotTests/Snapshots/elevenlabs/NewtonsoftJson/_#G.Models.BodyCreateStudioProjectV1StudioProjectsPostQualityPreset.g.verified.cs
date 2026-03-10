//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostQualityPreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output quality of the generated audio. Must be one of:<br/>
    /// 'standard' - standard output format, 128kbps with 44.1kHz sample rate.<br/>
    /// 'high' - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side.<br/>
    /// 'ultra' - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side.<br/>
    /// 'ultra_lossless' - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format.<br/>
    /// Default Value: standard
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreateStudioProjectV1StudioProjectsPostQualityPreset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard")]
        Standard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ultra")]
        Ultra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ultra_lossless")]
        UltraLossless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreateStudioProjectV1StudioProjectsPostQualityPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostQualityPreset value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostQualityPreset.Standard => "standard",
                BodyCreateStudioProjectV1StudioProjectsPostQualityPreset.High => "high",
                BodyCreateStudioProjectV1StudioProjectsPostQualityPreset.Ultra => "ultra",
                BodyCreateStudioProjectV1StudioProjectsPostQualityPreset.UltraLossless => "ultra_lossless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateStudioProjectV1StudioProjectsPostQualityPreset? ToEnum(string value)
        {
            return value switch
            {
                "standard" => BodyCreateStudioProjectV1StudioProjectsPostQualityPreset.Standard,
                "high" => BodyCreateStudioProjectV1StudioProjectsPostQualityPreset.High,
                "ultra" => BodyCreateStudioProjectV1StudioProjectsPostQualityPreset.Ultra,
                "ultra_lossless" => BodyCreateStudioProjectV1StudioProjectsPostQualityPreset.UltraLossless,
                _ => null,
            };
        }
    }
}