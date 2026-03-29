//HintName: G.Models.CreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest
    {
        /// <summary>
        /// The name of the index. Make sure you use a succinct and descriptive name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

        /// <summary>
        /// An array that specifies the [video understanding models](/v1.3/docs/concepts/models) and the [model options](/v1.3/docs/concepts/modalities#model-options) to be enabled for this index. Models determine what tasks you can perform with your videos. Model options determine which modalities the platform analyzes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems> Models { get; set; }

        /// <summary>
        /// An array specifying which add-ons should be enabled. Each entry in the array is an addon, and the following values are supported:<br/>
        /// - `thumbnail`: Enables thumbnail generation.<br/>
        /// If you don't provide this parameter, no add-ons will be enabled.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - You can only enable addons when using the Marengo video understanding model.<br/>
        /// - You cannot disable an add-on once the index has been created.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addons")]
        public global::System.Collections.Generic.IList<string>? Addons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest" /> class.
        /// </summary>
        /// <param name="indexName">
        /// The name of the index. Make sure you use a succinct and descriptive name.
        /// </param>
        /// <param name="models">
        /// An array that specifies the [video understanding models](/v1.3/docs/concepts/models) and the [model options](/v1.3/docs/concepts/modalities#model-options) to be enabled for this index. Models determine what tasks you can perform with your videos. Model options determine which modalities the platform analyzes.
        /// </param>
        /// <param name="addons">
        /// An array specifying which add-ons should be enabled. Each entry in the array is an addon, and the following values are supported:<br/>
        /// - `thumbnail`: Enables thumbnail generation.<br/>
        /// If you don't provide this parameter, no add-ons will be enabled.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - You can only enable addons when using the Marengo video understanding model.<br/>
        /// - You cannot disable an add-on once the index has been created.<br/>
        /// &lt;/Note&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest(
            string indexName,
            global::System.Collections.Generic.IList<global::G.IndexesPostRequestBodyContentApplicationJsonSchemaModelsItems> models,
            global::System.Collections.Generic.IList<string>? addons)
        {
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.Addons = addons;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest" /> class.
        /// </summary>
        public CreateRequest()
        {
        }
    }
}