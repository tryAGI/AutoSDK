//HintName: G.Models.ModelStatusModelStage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The stage of the underlying model.
    /// </summary>
    public enum ModelStatusModelStage
    {
        /// <summary>
        /// Models in this stage are deprecated. These models cannot be used.
        /// </summary>
        Deprecated,
        /// <summary>
        /// Models in this stage are for experimental purposes only.
        /// </summary>
        Experimental,
        /// <summary>
        /// If the model is on this stage, it means that this model is on the path to deprecation in near future. Only existing customers can use this model.
        /// </summary>
        Legacy,
        /// <summary>
        /// Unspecified model stage.
        /// </summary>
        ModelStageUnspecified,
        /// <summary>
        /// Models in this stage are more mature than experimental models.
        /// </summary>
        Preview,
        /// <summary>
        /// Models in this stage are retired. These models cannot be used.
        /// </summary>
        Retired,
        /// <summary>
        /// Models in this stage are considered stable and ready for production use.
        /// </summary>
        Stable,
        /// <summary>
        /// The underlying model is subject to lots of tunings.
        /// </summary>
        UnstableExperimental,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelStatusModelStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelStatusModelStage value)
        {
            return value switch
            {
                ModelStatusModelStage.Deprecated => "DEPRECATED",
                ModelStatusModelStage.Experimental => "EXPERIMENTAL",
                ModelStatusModelStage.Legacy => "LEGACY",
                ModelStatusModelStage.ModelStageUnspecified => "MODEL_STAGE_UNSPECIFIED",
                ModelStatusModelStage.Preview => "PREVIEW",
                ModelStatusModelStage.Retired => "RETIRED",
                ModelStatusModelStage.Stable => "STABLE",
                ModelStatusModelStage.UnstableExperimental => "UNSTABLE_EXPERIMENTAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelStatusModelStage? ToEnum(string value)
        {
            return value switch
            {
                "DEPRECATED" => ModelStatusModelStage.Deprecated,
                "EXPERIMENTAL" => ModelStatusModelStage.Experimental,
                "LEGACY" => ModelStatusModelStage.Legacy,
                "MODEL_STAGE_UNSPECIFIED" => ModelStatusModelStage.ModelStageUnspecified,
                "PREVIEW" => ModelStatusModelStage.Preview,
                "RETIRED" => ModelStatusModelStage.Retired,
                "STABLE" => ModelStatusModelStage.Stable,
                "UNSTABLE_EXPERIMENTAL" => ModelStatusModelStage.UnstableExperimental,
                _ => null,
            };
        }
    }
}