//HintName: G.Models.Pricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extensible pricing information for AI models.<br/>
    /// Price is calculated as:<br/>
    ///     credits = ceil((base_cost + credits_per_second * duration_seconds) * product(modifiers))<br/>
    /// For video models (per-second billing):<br/>
    ///     - base_cost is typically 0<br/>
    ///     - credits_per_second is the per-second rate<br/>
    ///     - duration_seconds is the video length<br/>
    ///     - modifiers adjust for resolution, audio generation, etc.<br/>
    /// For image models (per-generation billing):<br/>
    ///     - base_cost is the flat cost per generation (e.g., 5 credits)<br/>
    ///     - credits_per_second is 0<br/>
    ///     - duration_seconds is ignored (or 0)<br/>
    ///     - modifiers can still adjust for resolution, style, etc.<br/>
    /// Modifiers are only included when they affect pricing (i.e., non-1.0 values).
    /// </summary>
    public sealed partial class Pricing
    {
        /// <summary>
        /// Flat base cost in credits. Present for per-generation models (images). Duration-based models leave this unset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_cost")]
        public int? BaseCost { get; set; }

        /// <summary>
        /// Credit cost per second. Only present for duration-based models. Image/per-generation models leave this unset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits_per_second")]
        public int? CreditsPerSecond { get; set; }

        /// <summary>
        /// Pricing modifiers by dimension. Each dimension (e.g. 'resolution', 'generate_audio') maps option values to their price multipliers. Only non-1.0 modifiers are included (1.0 is the implicit default). Example: {'resolution': {'540p': 0.5, '1080p': 3.0}}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modifiers")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, double>>? Modifiers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pricing" /> class.
        /// </summary>
        /// <param name="baseCost">
        /// Flat base cost in credits. Present for per-generation models (images). Duration-based models leave this unset.
        /// </param>
        /// <param name="creditsPerSecond">
        /// Credit cost per second. Only present for duration-based models. Image/per-generation models leave this unset.
        /// </param>
        /// <param name="modifiers">
        /// Pricing modifiers by dimension. Each dimension (e.g. 'resolution', 'generate_audio') maps option values to their price multipliers. Only non-1.0 modifiers are included (1.0 is the implicit default). Example: {'resolution': {'540p': 0.5, '1080p': 3.0}}
        /// </param>
        public Pricing(
            int? baseCost,
            int? creditsPerSecond,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, double>>? modifiers)
        {
            this.BaseCost = baseCost;
            this.CreditsPerSecond = creditsPerSecond;
            this.Modifiers = modifiers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pricing" /> class.
        /// </summary>
        public Pricing()
        {
        }
    }
}