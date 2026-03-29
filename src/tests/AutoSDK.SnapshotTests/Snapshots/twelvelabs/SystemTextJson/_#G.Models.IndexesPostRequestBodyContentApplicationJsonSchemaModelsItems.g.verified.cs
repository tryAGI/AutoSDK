//HintName: G.Models.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems
    {
        /// <summary>
        /// The name of the model. The following models are available:<br/>
        ///   - **Embedding**: These models are proficient at performing tasks such as search and classification, enabling enhanced video understanding.<br/>
        ///     - `marengo3.0`: Enhanced model with sports intelligence and extended content support.<br/>
        ///     - `marengo2.7`: **Deprecation notice**: Starting mid-March 2026, your videos will be automatically reindexed to Marengo 3.0. Marengo 2.7 will be deprecated once reindexing completes. See the [Migration guide](/v1.3/docs/get-started/migration-guide) for details.<br/>
        ///   - **Generative**: These models generate text based on your videos.<br/>
        ///     - `pegasus1.2`: A model that analyzes multiple modalities to generate contextually relevant text based on the content of your videos.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// You cannot change the model configuration once the index has been created.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// An array that specifies which modalities the platform analyzes. For the Marengo and Pegasus models, you can specify one or both of the following model options: `visual` and `audio`. For more details, see the [Model options](/v1.3/docs/concepts/modalities#model-options) section.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ModelOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the model. The following models are available:<br/>
        ///   - **Embedding**: These models are proficient at performing tasks such as search and classification, enabling enhanced video understanding.<br/>
        ///     - `marengo3.0`: Enhanced model with sports intelligence and extended content support.<br/>
        ///     - `marengo2.7`: **Deprecation notice**: Starting mid-March 2026, your videos will be automatically reindexed to Marengo 3.0. Marengo 2.7 will be deprecated once reindexing completes. See the [Migration guide](/v1.3/docs/get-started/migration-guide) for details.<br/>
        ///   - **Generative**: These models generate text based on your videos.<br/>
        ///     - `pegasus1.2`: A model that analyzes multiple modalities to generate contextually relevant text based on the content of your videos.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// You cannot change the model configuration once the index has been created.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="modelOptions">
        /// An array that specifies which modalities the platform analyzes. For the Marengo and Pegasus models, you can specify one or both of the following model options: `visual` and `audio`. For more details, see the [Model options](/v1.3/docs/concepts/modalities#model-options) section.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems(
            string modelName,
            global::System.Collections.Generic.IList<string> modelOptions)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.ModelOptions = modelOptions ?? throw new global::System.ArgumentNullException(nameof(modelOptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems" /> class.
        /// </summary>
        public IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems()
        {
        }
    }
}