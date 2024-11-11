//HintName: G.Models.ClassifyResponseClassification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class ClassifyResponseClassification
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The input text that was classified<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// The predicted label for the associated query (only filled for single-label models)<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Prediction { get; set; }

        /// <summary>
        /// An array containing the predicted labels for the associated query (only filled for single-label classification)<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        public global::System.Collections.Generic.IList<string> Predictions { get; set; } = default!;

        /// <summary>
        /// The confidence score for the top predicted class (only filled for single-label classification)<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public float? Confidence { get; set; }

        /// <summary>
        /// An array containing the confidence scores of all the predictions in the same order<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidences")]
        public global::System.Collections.Generic.IList<float> Confidences { get; set; } = default!;

        /// <summary>
        /// A map containing each label and its confidence score according to the classifier. All the confidence scores add up to 1 for single-label classification. For multi-label classification the label confidences are independent of each other, so they don't have to sum up to 1.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ClassifyResponseClassificationLabels2> Labels { get; set; } = default!;

        /// <summary>
        /// The type of classification performed<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassifyResponseClassificationClassificationTypeJsonConverter))]
        public global::G.ClassifyResponseClassificationClassificationType ClassificationType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponseClassification" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="input">
        /// The input text that was classified<br/>
        /// Included only in responses
        /// </param>
        /// <param name="predictions">
        /// An array containing the predicted labels for the associated query (only filled for single-label classification)<br/>
        /// Included only in responses
        /// </param>
        /// <param name="confidences">
        /// An array containing the confidence scores of all the predictions in the same order<br/>
        /// Included only in responses
        /// </param>
        /// <param name="labels">
        /// A map containing each label and its confidence score according to the classifier. All the confidence scores add up to 1 for single-label classification. For multi-label classification the label confidences are independent of each other, so they don't have to sum up to 1.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="classificationType">
        /// The type of classification performed<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ClassifyResponseClassification(
            string? input,
            string id = default!,
            global::System.Collections.Generic.IList<string> predictions = default!,
            global::System.Collections.Generic.IList<float> confidences = default!,
            global::System.Collections.Generic.Dictionary<string, global::G.ClassifyResponseClassificationLabels2> labels = default!,
            global::G.ClassifyResponseClassificationClassificationType classificationType = default!)
        {
            this.Id = id;
            this.Input = input;
            this.Predictions = predictions;
            this.Confidences = confidences;
            this.Labels = labels;
            this.ClassificationType = classificationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyResponseClassification" /> class.
        /// </summary>
        public ClassifyResponseClassification()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.ClassifyResponseClassification? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ClassifyResponseClassification),
                jsonSerializerContext) as global::G.ClassifyResponseClassification;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ClassifyResponseClassification? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ClassifyResponseClassification>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ClassifyResponseClassification?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ClassifyResponseClassification),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ClassifyResponseClassification;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ClassifyResponseClassification?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ClassifyResponseClassification?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}