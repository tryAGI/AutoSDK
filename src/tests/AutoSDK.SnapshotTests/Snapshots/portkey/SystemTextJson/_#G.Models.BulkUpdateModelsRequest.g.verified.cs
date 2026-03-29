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
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ModelUpdateRequest> Models { get; set; }

        /// <summary>
        /// Whether to allow all models by default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_models")]
        public bool? AllowAllModels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateModelsRequest" /> class.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="allowAllModels">
        /// Whether to allow all models by default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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