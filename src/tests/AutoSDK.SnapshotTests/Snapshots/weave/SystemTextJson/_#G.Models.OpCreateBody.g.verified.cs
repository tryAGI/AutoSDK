//HintName: G.Models.OpCreateBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for creating an Op object via REST API.<br/>
    /// This model excludes project_id since it comes from the URL path in RESTful endpoints.
    /// </summary>
    public sealed partial class OpCreateBody
    {
        /// <summary>
        /// The name of this op. Ops with the same name will be versioned together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Complete source code for this op, including imports
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_code")]
        public string? SourceCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpCreateBody" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of this op. Ops with the same name will be versioned together.
        /// </param>
        /// <param name="sourceCode">
        /// Complete source code for this op, including imports
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpCreateBody(
            string? name,
            string? sourceCode)
        {
            this.Name = name;
            this.SourceCode = sourceCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpCreateBody" /> class.
        /// </summary>
        public OpCreateBody()
        {
        }
    }
}