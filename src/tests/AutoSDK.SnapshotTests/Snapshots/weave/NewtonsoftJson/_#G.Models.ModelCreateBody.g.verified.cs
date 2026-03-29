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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A description of this model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Complete source code for the Model class including imports
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceCode { get; set; } = default!;

        /// <summary>
        /// Additional attributes to be stored with the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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