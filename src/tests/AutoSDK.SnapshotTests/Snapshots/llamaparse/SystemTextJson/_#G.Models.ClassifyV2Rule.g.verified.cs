//HintName: G.Models.ClassifyV2Rule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A rule for classifying documents.
    /// </summary>
    public sealed partial class ClassifyV2Rule
    {
        /// <summary>
        /// Document type to assign when rule matches
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Natural language criteria for matching this rule
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
        /// Initializes a new instance of the <see cref="ClassifyV2Rule" /> class.
        /// </summary>
        /// <param name="type">
        /// Document type to assign when rule matches
        /// </param>
        /// <param name="description">
        /// Natural language criteria for matching this rule
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifyV2Rule(
            string type,
            string description)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyV2Rule" /> class.
        /// </summary>
        public ClassifyV2Rule()
        {
        }
    }
}