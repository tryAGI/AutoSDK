//HintName: G.Models.ScorerCreateBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScorerCreateBody
    {
        /// <summary>
        /// The name of this scorer.  Scorers with the same name will be versioned together.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A description of this scorer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Complete source code for the Scorer.score op including imports
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op_source_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string OpSourceCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScorerCreateBody" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of this scorer.  Scorers with the same name will be versioned together.
        /// </param>
        /// <param name="opSourceCode">
        /// Complete source code for the Scorer.score op including imports
        /// </param>
        /// <param name="description">
        /// A description of this scorer
        /// </param>
        public ScorerCreateBody(
            string name,
            string opSourceCode,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.OpSourceCode = opSourceCode ?? throw new global::System.ArgumentNullException(nameof(opSourceCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScorerCreateBody" /> class.
        /// </summary>
        public ScorerCreateBody()
        {
        }
    }
}