//HintName: G.Models.FourierDenoisingPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FourierDenoisingPlan
    {
        /// <summary>
        /// Whether Fourier denoising is enabled. Note that this is experimental and may not work as expected.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether automatic media detection is enabled. When enabled, the filter will automatically<br/>
        /// detect consistent background TV/music/radio and switch to more aggressive filtering settings.<br/>
        /// Only applies when enabled is true.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaDetectionEnabled")]
        public bool? MediaDetectionEnabled { get; set; }

        /// <summary>
        /// Static threshold in dB used as fallback when no baseline is established.<br/>
        /// Default Value: -35<br/>
        /// Example: -35
        /// </summary>
        /// <example>-35</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("staticThreshold")]
        public double? StaticThreshold { get; set; }

        /// <summary>
        /// How far below the rolling baseline to filter audio, in dB.<br/>
        /// Lower values (e.g., -10) are more aggressive, higher values (e.g., -20) are more conservative.<br/>
        /// Default Value: -15<br/>
        /// Example: -15
        /// </summary>
        /// <example>-15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("baselineOffsetDb")]
        public double? BaselineOffsetDb { get; set; }

        /// <summary>
        /// Rolling window size in milliseconds for calculating the audio baseline.<br/>
        /// Larger windows adapt more slowly but are more stable.<br/>
        /// Default Value: 3000<br/>
        /// Example: 3000
        /// </summary>
        /// <example>3000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("windowSizeMs")]
        public double? WindowSizeMs { get; set; }

        /// <summary>
        /// Percentile to use for baseline calculation (1-99).<br/>
        /// Higher percentiles (e.g., 85) focus on louder speech, lower percentiles (e.g., 50) include quieter speech.<br/>
        /// Default Value: 85<br/>
        /// Example: 85
        /// </summary>
        /// <example>85</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("baselinePercentile")]
        public double? BaselinePercentile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FourierDenoisingPlan" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether Fourier denoising is enabled. Note that this is experimental and may not work as expected.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mediaDetectionEnabled">
        /// Whether automatic media detection is enabled. When enabled, the filter will automatically<br/>
        /// detect consistent background TV/music/radio and switch to more aggressive filtering settings.<br/>
        /// Only applies when enabled is true.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="staticThreshold">
        /// Static threshold in dB used as fallback when no baseline is established.<br/>
        /// Default Value: -35<br/>
        /// Example: -35
        /// </param>
        /// <param name="baselineOffsetDb">
        /// How far below the rolling baseline to filter audio, in dB.<br/>
        /// Lower values (e.g., -10) are more aggressive, higher values (e.g., -20) are more conservative.<br/>
        /// Default Value: -15<br/>
        /// Example: -15
        /// </param>
        /// <param name="windowSizeMs">
        /// Rolling window size in milliseconds for calculating the audio baseline.<br/>
        /// Larger windows adapt more slowly but are more stable.<br/>
        /// Default Value: 3000<br/>
        /// Example: 3000
        /// </param>
        /// <param name="baselinePercentile">
        /// Percentile to use for baseline calculation (1-99).<br/>
        /// Higher percentiles (e.g., 85) focus on louder speech, lower percentiles (e.g., 50) include quieter speech.<br/>
        /// Default Value: 85<br/>
        /// Example: 85
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FourierDenoisingPlan(
            bool? enabled,
            bool? mediaDetectionEnabled,
            double? staticThreshold,
            double? baselineOffsetDb,
            double? windowSizeMs,
            double? baselinePercentile)
        {
            this.Enabled = enabled;
            this.MediaDetectionEnabled = mediaDetectionEnabled;
            this.StaticThreshold = staticThreshold;
            this.BaselineOffsetDb = baselineOffsetDb;
            this.WindowSizeMs = windowSizeMs;
            this.BaselinePercentile = baselinePercentile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FourierDenoisingPlan" /> class.
        /// </summary>
        public FourierDenoisingPlan()
        {
        }
    }
}