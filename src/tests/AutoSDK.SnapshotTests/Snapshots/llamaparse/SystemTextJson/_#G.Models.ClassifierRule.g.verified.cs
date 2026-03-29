//HintName: G.Models.ClassifierRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A rule for classifying documents - v0 simplified version.<br/>
    /// This represents a single classification rule that will be applied to documents.<br/>
    /// All rules are content-based and use natural language descriptions.
    /// </summary>
    public sealed partial class ClassifierRule
    {
        /// <summary>
        /// The document type to assign when this rule matches (e.g., 'invoice', 'receipt', 'contract')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Natural language description of what to classify. Be specific about the content characteristics that identify this document type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierRule" /> class.
        /// </summary>
        /// <param name="type">
        /// The document type to assign when this rule matches (e.g., 'invoice', 'receipt', 'contract')
        /// </param>
        /// <param name="description">
        /// Natural language description of what to classify. Be specific about the content characteristics that identify this document type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierRule(
            string type,
            string description)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierRule" /> class.
        /// </summary>
        public ClassifierRule()
        {
        }
    }
}