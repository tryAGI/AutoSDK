//HintName: G.Models.ConvertDocumentsRequestOptionsVlmPipelineModelLocal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// DEPRECATED: Options for running a local vision-language model for the vlm pipeline. The parameters refer to a model hosted on Hugging Face. This parameter is mutually exclusive with vlm_pipeline_model_api and vlm_pipeline_model. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class ConvertDocumentsRequestOptionsVlmPipelineModelLocal
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}