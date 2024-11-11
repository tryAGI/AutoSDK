//HintName: G.Models.LemurBaseParams.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurBaseParams
    {
        /// <summary>
        /// A list of completed transcripts with text. Up to a maximum of 100 files or 100 hours, whichever is lower.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TranscriptIds { get; set; }

        /// <summary>
        /// Custom formatted transcript data. Maximum size is the context limit of the selected model, which defaults to 100000.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_text")]
        public string? InputText { get; set; }

        /// <summary>
        /// Context to provide the model. This can be a string or a free-form JSON value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public global::G.OneOf<string, object>? Context { get; set; }

        /// <summary>
        /// The model that is used for the final prompt after compression is performed.<br/>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("final_model")]
        public global::G.AnyOf<global::G.LemurModel?, string>? FinalModel { get; set; }

        /// <summary>
        /// Max output size in tokens, up to 4000<br/>
        /// Default Value: 2000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_output_size")]
        public int? MaxOutputSize { get; set; }

        /// <summary>
        /// The temperature to use for the model.<br/>
        /// Higher values result in answers that are more creative, lower values are more conservative.<br/>
        /// Can be any value between 0.0 and 1.0 inclusive.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurBaseParams" /> class.
        /// </summary>
        /// <param name="transcriptIds">
        /// A list of completed transcripts with text. Up to a maximum of 100 files or 100 hours, whichever is lower.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </param>
        /// <param name="inputText">
        /// Custom formatted transcript data. Maximum size is the context limit of the selected model, which defaults to 100000.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </param>
        /// <param name="context">
        /// Context to provide the model. This can be a string or a free-form JSON value.
        /// </param>
        /// <param name="finalModel">
        /// The model that is used for the final prompt after compression is performed.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="maxOutputSize">
        /// Max output size in tokens, up to 4000<br/>
        /// Default Value: 2000
        /// </param>
        /// <param name="temperature">
        /// The temperature to use for the model.<br/>
        /// Higher values result in answers that are more creative, lower values are more conservative.<br/>
        /// Can be any value between 0.0 and 1.0 inclusive.<br/>
        /// Default Value: 0F
        /// </param>
        public LemurBaseParams(
            global::System.Collections.Generic.IList<global::System.Guid>? transcriptIds,
            string? inputText,
            global::G.OneOf<string, object>? context,
            global::G.AnyOf<global::G.LemurModel?, string>? finalModel,
            int? maxOutputSize,
            float? temperature)
        {
            this.TranscriptIds = transcriptIds;
            this.InputText = inputText;
            this.Context = context;
            this.FinalModel = finalModel;
            this.MaxOutputSize = maxOutputSize;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurBaseParams" /> class.
        /// </summary>
        public LemurBaseParams()
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
        public static global::G.LemurBaseParams? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.LemurBaseParams>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.LemurBaseParams?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.LemurBaseParams?>(serializer.Deserialize<global::G.LemurBaseParams>(jsonReader));
        }

    }
}