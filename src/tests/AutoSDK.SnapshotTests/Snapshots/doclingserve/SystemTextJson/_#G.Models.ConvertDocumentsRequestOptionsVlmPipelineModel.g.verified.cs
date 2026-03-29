//HintName: G.Models.ConvertDocumentsRequestOptionsVlmPipelineModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// DEPRECATED: Preset of local and API models for the vlm pipeline. This parameter is mutually exclusive with vlm_pipeline_model_local and vlm_pipeline_model_api. Use the other options for more parameters. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class ConvertDocumentsRequestOptionsVlmPipelineModel
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}