//HintName: G.Models.SageMakerConfigurationVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SageMakerConfigurationVariant2
    {
        /// <summary>
        /// Custom attributes for SageMaker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amzn_sagemaker_custom_attributes")]
        public string? AmznSagemakerCustomAttributes { get; set; }

        /// <summary>
        /// Target model for SageMaker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amzn_sagemaker_target_model")]
        public string? AmznSagemakerTargetModel { get; set; }

        /// <summary>
        /// Target variant for SageMaker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amzn_sagemaker_target_variant")]
        public string? AmznSagemakerTargetVariant { get; set; }

        /// <summary>
        /// Target container hostname
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amzn_sagemaker_target_container_hostname")]
        public string? AmznSagemakerTargetContainerHostname { get; set; }

        /// <summary>
        /// Inference ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amzn_sagemaker_inference_id")]
        public string? AmznSagemakerInferenceId { get; set; }

        /// <summary>
        /// Enable explanations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amzn_sagemaker_enable_explanations")]
        public string? AmznSagemakerEnableExplanations { get; set; }

        /// <summary>
        /// Inference component
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amzn_sagemaker_inference_component")]
        public string? AmznSagemakerInferenceComponent { get; set; }

        /// <summary>
        /// Session ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amzn_sagemaker_session_id")]
        public string? AmznSagemakerSessionId { get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amzn_sagemaker_model_name")]
        public string? AmznSagemakerModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SageMakerConfigurationVariant2" /> class.
        /// </summary>
        /// <param name="amznSagemakerCustomAttributes">
        /// Custom attributes for SageMaker
        /// </param>
        /// <param name="amznSagemakerTargetModel">
        /// Target model for SageMaker
        /// </param>
        /// <param name="amznSagemakerTargetVariant">
        /// Target variant for SageMaker
        /// </param>
        /// <param name="amznSagemakerTargetContainerHostname">
        /// Target container hostname
        /// </param>
        /// <param name="amznSagemakerInferenceId">
        /// Inference ID
        /// </param>
        /// <param name="amznSagemakerEnableExplanations">
        /// Enable explanations
        /// </param>
        /// <param name="amznSagemakerInferenceComponent">
        /// Inference component
        /// </param>
        /// <param name="amznSagemakerSessionId">
        /// Session ID
        /// </param>
        /// <param name="amznSagemakerModelName">
        /// Model name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SageMakerConfigurationVariant2(
            string? amznSagemakerCustomAttributes,
            string? amznSagemakerTargetModel,
            string? amznSagemakerTargetVariant,
            string? amznSagemakerTargetContainerHostname,
            string? amznSagemakerInferenceId,
            string? amznSagemakerEnableExplanations,
            string? amznSagemakerInferenceComponent,
            string? amznSagemakerSessionId,
            string? amznSagemakerModelName)
        {
            this.AmznSagemakerCustomAttributes = amznSagemakerCustomAttributes;
            this.AmznSagemakerTargetModel = amznSagemakerTargetModel;
            this.AmznSagemakerTargetVariant = amznSagemakerTargetVariant;
            this.AmznSagemakerTargetContainerHostname = amznSagemakerTargetContainerHostname;
            this.AmznSagemakerInferenceId = amznSagemakerInferenceId;
            this.AmznSagemakerEnableExplanations = amznSagemakerEnableExplanations;
            this.AmznSagemakerInferenceComponent = amznSagemakerInferenceComponent;
            this.AmznSagemakerSessionId = amznSagemakerSessionId;
            this.AmznSagemakerModelName = amznSagemakerModelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SageMakerConfigurationVariant2" /> class.
        /// </summary>
        public SageMakerConfigurationVariant2()
        {
        }
    }
}