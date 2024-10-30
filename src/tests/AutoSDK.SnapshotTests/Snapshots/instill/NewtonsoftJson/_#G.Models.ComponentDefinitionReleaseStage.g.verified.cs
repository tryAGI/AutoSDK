//HintName: G.Models.ComponentDefinitionReleaseStage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// - RELEASE_STAGE_OPEN_FOR_CONTRIBUTION: This component is unimplemented and community contributions are welcome<br/>
    /// for this component.<br/>
    /// It is recommended that the major and minor versions for definitions at<br/>
    /// this release stage is kept at 0, e.g., `0.0.1`, `0.0.4`, etc.<br/>
    ///  - RELEASE_STAGE_COMING_SOON: The implementation of this component is planned and will be tackled by<br/>
    /// the Instill AI team.<br/>
    /// It is recommended that the major and minor versions for definitions at<br/>
    /// this release stage is kept at 0, e.g., `0.0.1`, `0.0.4`, etc.<br/>
    ///  - RELEASE_STAGE_ALPHA: Initial implementation intended to gather feedback and issues from early<br/>
    /// adopters. Alpha releases are discouraged for production use cases.<br/>
    /// The `version` field in the definition must have `alpha` as its first<br/>
    /// pre-release identifier, e.g., `0.1.0-alpha`, `0.1.3-alpha.1`.<br/>
    ///  - RELEASE_STAGE_BETA: The component has reached stability and no backwards incompatible<br/>
    /// changes are expected. Before reaching general availability, it should be<br/>
    /// validated by a broader group of users. Some fixes might be added during<br/>
    /// this process.<br/>
    /// The `version` field in the definition must have `beta` as its first<br/>
    /// pre-release identifier, e.g., `0.1.0-beta`, `0.1.3-beta.1`.<br/>
    ///  - RELEASE_STAGE_GA: Generally available - ready for use in production and fully supported by<br/>
    /// Instill AI.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ComponentDefinitionReleaseStage
    {
        /// <summary>
        /// This component is unimplemented and community contributions are welcome
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RELEASE_STAGE_OPEN_FOR_CONTRIBUTION")]
        RELEASESTAGEOPENFORCONTRIBUTION,
        /// <summary>
        /// The implementation of this component is planned and will be tackled by
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RELEASE_STAGE_COMING_SOON")]
        RELEASESTAGECOMINGSOON,
        /// <summary>
        /// Initial implementation intended to gather feedback and issues from early
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RELEASE_STAGE_ALPHA")]
        RELEASESTAGEALPHA,
        /// <summary>
        /// The component has reached stability and no backwards incompatible
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RELEASE_STAGE_BETA")]
        RELEASESTAGEBETA,
        /// <summary>
        /// Generally available - ready for use in production and fully supported by
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RELEASE_STAGE_GA")]
        RELEASESTAGEGA,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComponentDefinitionReleaseStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComponentDefinitionReleaseStage value)
        {
            return value switch
            {
                ComponentDefinitionReleaseStage.RELEASESTAGEOPENFORCONTRIBUTION => "RELEASE_STAGE_OPEN_FOR_CONTRIBUTION",
                ComponentDefinitionReleaseStage.RELEASESTAGECOMINGSOON => "RELEASE_STAGE_COMING_SOON",
                ComponentDefinitionReleaseStage.RELEASESTAGEALPHA => "RELEASE_STAGE_ALPHA",
                ComponentDefinitionReleaseStage.RELEASESTAGEBETA => "RELEASE_STAGE_BETA",
                ComponentDefinitionReleaseStage.RELEASESTAGEGA => "RELEASE_STAGE_GA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComponentDefinitionReleaseStage? ToEnum(string value)
        {
            return value switch
            {
                "RELEASE_STAGE_OPEN_FOR_CONTRIBUTION" => ComponentDefinitionReleaseStage.RELEASESTAGEOPENFORCONTRIBUTION,
                "RELEASE_STAGE_COMING_SOON" => ComponentDefinitionReleaseStage.RELEASESTAGECOMINGSOON,
                "RELEASE_STAGE_ALPHA" => ComponentDefinitionReleaseStage.RELEASESTAGEALPHA,
                "RELEASE_STAGE_BETA" => ComponentDefinitionReleaseStage.RELEASESTAGEBETA,
                "RELEASE_STAGE_GA" => ComponentDefinitionReleaseStage.RELEASESTAGEGA,
                _ => null,
            };
        }
    }
}