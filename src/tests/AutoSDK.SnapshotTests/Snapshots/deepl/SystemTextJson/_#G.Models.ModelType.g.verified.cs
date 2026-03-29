//HintName: G.Models.ModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies which DeepL model should be used for translation.<br/>
    /// Possible values are:<br/>
    /// * `latency_optimized` (default) - uses lower latency “classic” translation models, which support all language pairs;<br/>
    ///   default value<br/>
    /// * `quality_optimized` - uses higher latency, improved quality “next-gen” translation models, which support only a<br/>
    ///   subset of language pairs; if a language pair that is not supported by next-gen models is included in the<br/>
    ///   request, it will fail. Consider using prefer_quality_optimized instead.<br/>
    /// * `prefer_quality_optimized` - prioritizes use of higher latency, improved quality “next-gen” translation models,<br/>
    ///   which support only a subset of DeepL languages; if a request includes a language pair not supported by<br/>
    ///   next-gen models, the request will fall back to latency_optimized classic models.
    /// </summary>
    public enum ModelType
    {
        /// <summary>
        /// 
        /// </summary>
        LatencyOptimized,
        /// <summary>
        /// 
        /// </summary>
        PreferQualityOptimized,
        /// <summary>
        /// 
        /// </summary>
        QualityOptimized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelType value)
        {
            return value switch
            {
                ModelType.LatencyOptimized => "latency_optimized",
                ModelType.PreferQualityOptimized => "prefer_quality_optimized",
                ModelType.QualityOptimized => "quality_optimized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelType? ToEnum(string value)
        {
            return value switch
            {
                "latency_optimized" => ModelType.LatencyOptimized,
                "prefer_quality_optimized" => ModelType.PreferQualityOptimized,
                "quality_optimized" => ModelType.QualityOptimized,
                _ => null,
            };
        }
    }
}