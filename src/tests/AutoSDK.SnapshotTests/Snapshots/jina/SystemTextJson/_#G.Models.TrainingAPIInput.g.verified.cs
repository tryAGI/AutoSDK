//HintName: G.Models.TrainingAPIInput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The input to the API for train the classifier. OpenAI compatible
    /// </summary>
    public sealed partial class TrainingAPIInput
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
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The identifier of the classifier. If not provided, a new classifier will be created.<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_id")]
        public string? ClassifierId { get; set; }

        /// <summary>
        /// The visibility of the classifier when created. Will be ignored if `classifier_id` is provided<br/>
        /// Default Value: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TrainingAPIInputVisibilityJsonConverter))]
        public global::G.TrainingAPIInputVisibility? Visibility { get; set; }

        /// <summary>
        /// List of text and images and labels or a single text and image and label to train the classifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverterFactory3))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextExampleDoc, global::G.ImageExampleDoc>>, global::G.TextExampleDoc, global::G.ImageExampleDoc> Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingAPIInput" /> class.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// - `jina-embeddings-v2-base-en`,	137M,	768<br/>
        /// - `jina-embeddings-v2-base-es`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-de`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-zh`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-code`,	137M,	768<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </param>
        /// <param name="classifierId">
        /// The identifier of the classifier. If not provided, a new classifier will be created.<br/>
        /// You can provide only either `model` or `classifier_id`
        /// </param>
        /// <param name="visibility">
        /// The visibility of the classifier when created. Will be ignored if `classifier_id` is provided<br/>
        /// Default Value: public
        /// </param>
        /// <param name="input">
        /// List of text and images and labels or a single text and image and label to train the classifier
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TrainingAPIInput(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextExampleDoc, global::G.ImageExampleDoc>>, global::G.TextExampleDoc, global::G.ImageExampleDoc> input,
            string? model,
            string? classifierId,
            global::G.TrainingAPIInputVisibility? visibility)
        {
            this.Input = input;
            this.Model = model;
            this.ClassifierId = classifierId;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingAPIInput" /> class.
        /// </summary>
        public TrainingAPIInput()
        {
        }
    }
}