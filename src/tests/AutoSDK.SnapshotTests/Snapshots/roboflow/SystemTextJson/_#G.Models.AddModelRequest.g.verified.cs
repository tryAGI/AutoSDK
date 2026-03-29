//HintName: G.Models.AddModelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to add a model to the inference server.<br/>
    /// Attributes:<br/>
    ///     model_id (str): A unique model identifier.<br/>
    ///     model_type (Optional[str]): The type of the model, usually referring to what task the model performs.<br/>
    ///     api_key (Optional[str]): Roboflow API Key that will be passed to the model during initialization for artifact retrieval.
    /// </summary>
    public sealed partial class AddModelRequest
    {
        /// <summary>
        /// A unique model identifier<br/>
        /// Example: raccoon-detector-1
        /// </summary>
        /// <example>raccoon-detector-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// The type of the model, usually referring to what task the model performs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        public string? ModelType { get; set; }

        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddModelRequest" /> class.
        /// </summary>
        /// <param name="modelId">
        /// A unique model identifier<br/>
        /// Example: raccoon-detector-1
        /// </param>
        /// <param name="modelType">
        /// The type of the model, usually referring to what task the model performs
        /// </param>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddModelRequest(
            string modelId,
            string? modelType,
            string? apiKey)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelType = modelType;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddModelRequest" /> class.
        /// </summary>
        public AddModelRequest()
        {
        }
    }
}