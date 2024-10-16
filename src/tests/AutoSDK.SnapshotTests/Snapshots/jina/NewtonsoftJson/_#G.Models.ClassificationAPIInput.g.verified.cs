//HintName: G.Models.ClassificationAPIInput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The input to the API for classify endpoint. OpenAI compatible
    /// </summary>
    public sealed partial class ClassificationAPIInput
    {
        /// <summary>
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// - `jina-embeddings-v2-base-en`,	137M,	768<br/>
        /// - `jina-embeddings-v2-base-es`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-de`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-zh`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-code`,	137M,	768<br/>
        /// - `jina-embeddings-v3`,	570M,	1024<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The identifier of the classifier. If not provided, a new classifier will be created.<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classifier_id")]
        public string? ClassifierId { get; set; }

        /// <summary>
        /// List of text and images or a single text and image for classification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ApiSchemasClassificationTextDoc, global::G.ApiSchemasClassificationImageDoc, string>>, global::G.ApiSchemasClassificationTextDoc, global::G.ApiSchemasClassificationImageDoc, string> Input { get; set; } = default!;

        /// <summary>
        /// List of labels used for classification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ClassificationAPIInput? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ClassificationAPIInput>(
                json,
                jsonSerializerOptions);
        }

    }
}