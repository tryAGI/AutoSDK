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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of this scorer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Complete source code for the Scorer.score op including imports
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op_source_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OpSourceCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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