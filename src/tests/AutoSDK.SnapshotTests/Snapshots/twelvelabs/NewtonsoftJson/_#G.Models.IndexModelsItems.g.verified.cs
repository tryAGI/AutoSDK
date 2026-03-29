//HintName: G.Models.IndexModelsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexModelsItems
    {
        /// <summary>
        /// A string representing the name of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// An array of strings that contains the [model options](/v1.3/docs/concepts/modalities#model-options) enabled for this index.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_options")]
        public global::System.Collections.Generic.IList<string>? ModelOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModelsItems" /> class.
        /// </summary>
        /// <param name="modelName">
        /// A string representing the name of the model.
        /// </param>
        /// <param name="modelOptions">
        /// An array of strings that contains the [model options](/v1.3/docs/concepts/modalities#model-options) enabled for this index.
        /// </param>
        public IndexModelsItems(
            string? modelName,
            global::System.Collections.Generic.IList<string>? modelOptions)
        {
            this.ModelName = modelName;
            this.ModelOptions = modelOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModelsItems" /> class.
        /// </summary>
        public IndexModelsItems()
        {
        }
    }
}