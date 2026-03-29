//HintName: G.Models.BulkUpdateModelsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateModelsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelUpdateRequest> Models { get; set; } = default!;

        /// <summary>
        /// Whether to allow all models by default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_all_models")]
        public bool? AllowAllModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateModelsRequest" /> class.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="allowAllModels">
        /// Whether to allow all models by default
        /// </param>
        public BulkUpdateModelsRequest(
            global::System.Collections.Generic.IList<global::G.ModelUpdateRequest> models,
            bool? allowAllModels)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.AllowAllModels = allowAllModels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateModelsRequest" /> class.
        /// </summary>
        public BulkUpdateModelsRequest()
        {
        }
    }
}