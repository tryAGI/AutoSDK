//HintName: G.Models.Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about a Generative Language Model.
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// Required. The resource name of the `Model`. Format: `models/{model}` with a `{model}` naming convention of: * "{base_model_id}-{version}" Examples: * `models/chat-bison-001`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The human-readable name of the model. E.g. "Chat Bison". The name can be up to 128 characters long and can consist of any UTF-8 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// A short description of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Required. The version number of the model. This represents the major version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Required. The name of the base model, pass this to the generation request. Examples: * `chat-bison`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseModelId")]
        public string? BaseModelId { get; set; }

        /// <summary>
        /// Controls the randomness of the output. Values can range over `[0.0,1.0]`, inclusive. A value closer to `1.0` will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model. This value specifies default to be used by the backend while making the call to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// For Top-k sampling. Top-k sampling considers the set of `top_k` most probable tokens. This value specifies default to be used by the backend while making the call to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// For Nucleus sampling. Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`. This value specifies default to be used by the backend while making the call to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topP")]
        public float? TopP { get; set; }

        /// <summary>
        /// Maximum number of input tokens allowed for this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputTokenLimit")]
        public int? InputTokenLimit { get; set; }

        /// <summary>
        /// Maximum number of output tokens available for this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputTokenLimit")]
        public int? OutputTokenLimit { get; set; }

        /// <summary>
        /// The model's supported generation methods. The method names are defined as Pascal case strings, such as `generateMessage` which correspond to API methods.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedGenerationMethods")]
        public global::System.Collections.Generic.IList<string>? SupportedGenerationMethods { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}