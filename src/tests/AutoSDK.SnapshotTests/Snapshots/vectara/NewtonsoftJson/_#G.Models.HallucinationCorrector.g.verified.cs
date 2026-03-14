//HintName: G.Models.HallucinationCorrector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A hallucination corrector that detects and corrects hallucinations in generated text.
    /// </summary>
    public sealed partial class HallucinationCorrector
    {
        /// <summary>
        /// The unique ID for the Hallucination Corrector (HC).<br/>
        /// Example: hcm_520721853
        /// </summary>
        /// <example>hcm_520721853</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The hallucination corrector name, typically including the base name and variant.<br/>
        /// Example: vhc-small-1.0
        /// </summary>
        /// <example>vhc-small-1.0</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The hallucination corrector type. Defaults to `vectara`.<br/>
        /// Default Value: vectara
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A short description of the hallucination corrector’s purpose.<br/>
        /// Example: Basic model for hallucination correction in AI-generated text.
        /// </summary>
        /// <example>Basic model for hallucination correction in AI-generated text.</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the hallucination corrector is enabled and available for use in hallucination correction workflows.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HallucinationCorrector" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID for the Hallucination Corrector (HC).<br/>
        /// Example: hcm_520721853
        /// </param>
        /// <param name="name">
        /// The hallucination corrector name, typically including the base name and variant.<br/>
        /// Example: vhc-small-1.0
        /// </param>
        /// <param name="type">
        /// The hallucination corrector type. Defaults to `vectara`.<br/>
        /// Default Value: vectara
        /// </param>
        /// <param name="description">
        /// A short description of the hallucination corrector’s purpose.<br/>
        /// Example: Basic model for hallucination correction in AI-generated text.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the hallucination corrector is enabled and available for use in hallucination correction workflows.<br/>
        /// Example: true
        /// </param>
        public HallucinationCorrector(
            string? id,
            string? name,
            string? type,
            string? description,
            bool? enabled)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HallucinationCorrector" /> class.
        /// </summary>
        public HallucinationCorrector()
        {
        }
    }
}