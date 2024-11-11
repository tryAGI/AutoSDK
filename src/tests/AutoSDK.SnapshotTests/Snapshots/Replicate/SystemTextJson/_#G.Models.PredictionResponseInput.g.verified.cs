//HintName: G.Models.PredictionResponseInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionResponseInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public double? Steps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance")]
        public double? Guidance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        public double? Interval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public double? SafetyTolerance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionResponseInput" /> class.
        /// </summary>
        /// <param name="seed"></param>
        /// <param name="steps"></param>
        /// <param name="prompt"></param>
        /// <param name="guidance"></param>
        /// <param name="interval"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="safetyTolerance"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PredictionResponseInput(
            double? seed,
            double? steps,
            string? prompt,
            double? guidance,
            double? interval,
            string? aspectRatio,
            double? safetyTolerance)
        {
            this.Seed = seed;
            this.Steps = steps;
            this.Prompt = prompt;
            this.Guidance = guidance;
            this.Interval = interval;
            this.AspectRatio = aspectRatio;
            this.SafetyTolerance = safetyTolerance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionResponseInput" /> class.
        /// </summary>
        public PredictionResponseInput()
        {
        }
    }
}