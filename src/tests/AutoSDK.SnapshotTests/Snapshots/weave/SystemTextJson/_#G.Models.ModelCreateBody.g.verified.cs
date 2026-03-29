//HintName: G.Models.ModelCreateBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelCreateBody
    {
        /// <summary>
        /// The name of this model. Models with the same name will be versioned together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Complete source code for the Model class including imports
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceCode { get; set; }

        /// <summary>
        /// Additional attributes to be stored with the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCreateBody" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of this model. Models with the same name will be versioned together.
        /// </param>
        /// <param name="sourceCode">
        /// Complete source code for the Model class including imports
        /// </param>
        /// <param name="description">
        /// A description of this model
        /// </param>
        /// <param name="attributes">
        /// Additional attributes to be stored with the model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelCreateBody(
            string name,
            string sourceCode,
            string? description,
            object? attributes)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.SourceCode = sourceCode ?? throw new global::System.ArgumentNullException(nameof(sourceCode));
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCreateBody" /> class.
        /// </summary>
        public ModelCreateBody()
        {
        }
    }
}