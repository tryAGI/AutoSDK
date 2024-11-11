//HintName: G.Models.LemurQuestion.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurQuestion
    {
        /// <summary>
        /// The question you wish to ask. For more complex questions use default model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("question", Required = global::Newtonsoft.Json.Required.Always)]
        public string Question { get; set; } = default!;

        /// <summary>
        /// Any context about the transcripts you wish to provide. This can be a string or any object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public global::G.OneOf<string, object>? Context { get; set; }

        /// <summary>
        /// How you want the answer to be returned. This can be any text. Can't be used with answer_options. Examples: "short sentence", "bullet points"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answer_format")]
        public string? AnswerFormat { get; set; }

        /// <summary>
        /// What discrete options to return. Useful for precise responses. Can't be used with answer_format. Example: ["Yes", "No"]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answer_options")]
        public global::System.Collections.Generic.IList<string>? AnswerOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurQuestion" /> class.
        /// </summary>
        /// <param name="question">
        /// The question you wish to ask. For more complex questions use default model.
        /// </param>
        /// <param name="context">
        /// Any context about the transcripts you wish to provide. This can be a string or any object.
        /// </param>
        /// <param name="answerFormat">
        /// How you want the answer to be returned. This can be any text. Can't be used with answer_options. Examples: "short sentence", "bullet points"
        /// </param>
        /// <param name="answerOptions">
        /// What discrete options to return. Useful for precise responses. Can't be used with answer_format. Example: ["Yes", "No"]
        /// </param>
        public LemurQuestion(
            string question,
            global::G.OneOf<string, object>? context,
            string? answerFormat,
            global::System.Collections.Generic.IList<string>? answerOptions)
        {
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
            this.Context = context;
            this.AnswerFormat = answerFormat;
            this.AnswerOptions = answerOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurQuestion" /> class.
        /// </summary>
        public LemurQuestion()
        {
        }


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
        public static global::G.LemurQuestion? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.LemurQuestion>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.LemurQuestion?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.LemurQuestion?>(serializer.Deserialize<global::G.LemurQuestion>(jsonReader));
        }

    }
}