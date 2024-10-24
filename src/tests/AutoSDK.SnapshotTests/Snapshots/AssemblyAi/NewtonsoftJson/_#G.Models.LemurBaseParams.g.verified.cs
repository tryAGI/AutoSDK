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

    }
}