//HintName: G.Models.DatasetExpansionWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetExpansionWrite
    {
        /// <summary>
        /// The model to use for synthetic data generation<br/>
        /// Example: gpt-4
        /// </summary>
        /// <example>gpt-4</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Number of synthetic samples to generate<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("sample_count")]
        public int? SampleCount { get; set; }

        /// <summary>
        /// Fields to preserve patterns from original data<br/>
        /// Example: [input, expected_output]
        /// </summary>
        /// <example>[input, expected_output]</example>
        [global::Newtonsoft.Json.JsonProperty("preserve_fields")]
        public global::System.Collections.Generic.IList<string>? PreserveFields { get; set; }

        /// <summary>
        /// Additional instructions for data variation<br/>
        /// Example: Create variations that test edge cases
        /// </summary>
        /// <example>Create variations that test edge cases</example>
        [global::Newtonsoft.Json.JsonProperty("variation_instructions")]
        public string? VariationInstructions { get; set; }

        /// <summary>
        /// Custom prompt to use for generation instead of auto-generated one
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_prompt")]
        public string? CustomPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetExpansionWrite" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for synthetic data generation<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="sampleCount">
        /// Number of synthetic samples to generate<br/>
        /// Example: 10
        /// </param>
        /// <param name="preserveFields">
        /// Fields to preserve patterns from original data<br/>
        /// Example: [input, expected_output]
        /// </param>
        /// <param name="variationInstructions">
        /// Additional instructions for data variation<br/>
        /// Example: Create variations that test edge cases
        /// </param>
        /// <param name="customPrompt">
        /// Custom prompt to use for generation instead of auto-generated one
        /// </param>
        public DatasetExpansionWrite(
            string model,
            int? sampleCount,
            global::System.Collections.Generic.IList<string>? preserveFields,
            string? variationInstructions,
            string? customPrompt)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SampleCount = sampleCount;
            this.PreserveFields = preserveFields;
            this.VariationInstructions = variationInstructions;
            this.CustomPrompt = customPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetExpansionWrite" /> class.
        /// </summary>
        public DatasetExpansionWrite()
        {
        }
    }
}