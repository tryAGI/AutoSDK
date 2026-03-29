//HintName: G.Models.DatasetExpansionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetExpansionResponse
    {
        /// <summary>
        /// List of generated synthetic dataset items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_samples")]
        public global::System.Collections.Generic.IList<global::G.DatasetItem>? GeneratedSamples { get; set; }

        /// <summary>
        /// Model used for generation<br/>
        /// Example: gpt-4
        /// </summary>
        /// <example>gpt-4</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Total number of samples generated<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("total_generated")]
        public int? TotalGenerated { get; set; }

        /// <summary>
        /// Generation timestamp<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_time")]
        public global::System.DateTime? GenerationTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetExpansionResponse" /> class.
        /// </summary>
        /// <param name="generatedSamples">
        /// List of generated synthetic dataset items
        /// </param>
        /// <param name="model">
        /// Model used for generation<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="totalGenerated">
        /// Total number of samples generated<br/>
        /// Example: 10
        /// </param>
        /// <param name="generationTime">
        /// Generation timestamp<br/>
        /// Included only in responses
        /// </param>
        public DatasetExpansionResponse(
            global::System.Collections.Generic.IList<global::G.DatasetItem>? generatedSamples,
            string? model,
            int? totalGenerated,
            global::System.DateTime? generationTime)
        {
            this.GeneratedSamples = generatedSamples;
            this.Model = model;
            this.TotalGenerated = totalGenerated;
            this.GenerationTime = generationTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetExpansionResponse" /> class.
        /// </summary>
        public DatasetExpansionResponse()
        {
        }
    }
}