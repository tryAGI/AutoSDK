//HintName: G.Models.ReleaseStage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ReleaseStage defines the stage of a release.<br/>
    ///  - RELEASE_STAGE_ALPHA: Alpha.<br/>
    ///  - RELEASE_STAGE_BETA: Beta.<br/>
    ///  - RELEASE_STAGE_GENERALLY_AVAILABLE: Generally available.<br/>
    ///  - RELEASE_STAGE_CUSTOM: Custom.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReleaseStage
    {
        /// <summary>
        /// Alpha.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RELEASE_STAGE_ALPHA")]
        ALPHA,
        /// <summary>
        /// Beta.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RELEASE_STAGE_BETA")]
        BETA,
        /// <summary>
        /// Generally available.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RELEASE_STAGE_GENERALLY_AVAILABLE")]
        GENERALLYAVAILABLE,
        /// <summary>
        /// Custom.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RELEASE_STAGE_CUSTOM")]
        CUSTOM,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReleaseStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReleaseStage value)
        {
            return value switch
            {
                ReleaseStage.ALPHA => "RELEASE_STAGE_ALPHA",
                ReleaseStage.BETA => "RELEASE_STAGE_BETA",
                ReleaseStage.GENERALLYAVAILABLE => "RELEASE_STAGE_GENERALLY_AVAILABLE",
                ReleaseStage.CUSTOM => "RELEASE_STAGE_CUSTOM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReleaseStage? ToEnum(string value)
        {
            return value switch
            {
                "RELEASE_STAGE_ALPHA" => ReleaseStage.ALPHA,
                "RELEASE_STAGE_BETA" => ReleaseStage.BETA,
                "RELEASE_STAGE_GENERALLY_AVAILABLE" => ReleaseStage.GENERALLYAVAILABLE,
                "RELEASE_STAGE_CUSTOM" => ReleaseStage.CUSTOM,
                _ => null,
            };
        }
    }
}