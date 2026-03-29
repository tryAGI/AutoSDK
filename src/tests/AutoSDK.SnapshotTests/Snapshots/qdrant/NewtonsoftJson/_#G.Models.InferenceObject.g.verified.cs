//HintName: G.Models.InferenceObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// WARN: Work-in-progress, unimplemented<br/>
    /// Custom object for embedding. Requires inference infrastructure, unimplemented.
    /// </summary>
    public sealed partial class InferenceObject
    {
        /// <summary>
        /// Arbitrary data, used as input for the embedding model. Used if the model requires more than one input or a custom input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public object Object { get; set; } = default!;

        /// <summary>
        /// Name of the model used to generate the vector. List of available models depends on a provider.<br/>
        /// Example: jinaai/jina-embeddings-v2-base-en
        /// </summary>
        /// <example>jinaai/jina-embeddings-v2-base-en</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Parameters for the model Values of the parameters are model-specific
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public object? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceObject" /> class.
        /// </summary>
        /// <param name="object">
        /// Arbitrary data, used as input for the embedding model. Used if the model requires more than one input or a custom input.
        /// </param>
        /// <param name="model">
        /// Name of the model used to generate the vector. List of available models depends on a provider.<br/>
        /// Example: jinaai/jina-embeddings-v2-base-en
        /// </param>
        /// <param name="options">
        /// Parameters for the model Values of the parameters are model-specific
        /// </param>
        public InferenceObject(
            object @object,
            string model,
            object? options)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceObject" /> class.
        /// </summary>
        public InferenceObject()
        {
        }
    }
}