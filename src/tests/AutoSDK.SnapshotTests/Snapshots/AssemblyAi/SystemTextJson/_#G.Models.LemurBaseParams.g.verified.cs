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
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TranscriptIds { get; set; }

        /// <summary>
        /// Custom formatted transcript data. Maximum size is the context limit of the selected model, which defaults to 100000.<br/>
        /// Use either transcript_ids or input_text as input into LeMUR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text")]
        public string? InputText { get; set; }

        /// <summary>
        /// Context to provide the model. This can be a string or a free-form JSON value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, object>))]
        public global::G.OneOf<string, object>? Context { get; set; }

        /// <summary>
        /// The model that is used for the final prompt after compression is performed.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.LemurModel?, string>))]
        public global::G.AnyOf<global::G.LemurModel?, string>? FinalModel { get; set; }

        /// <summary>
        /// Max output size in tokens, up to 4000<br/>
        /// Default Value: 2000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_size")]
        public int? MaxOutputSize { get; set; }

        /// <summary>
        /// The temperature to use for the model.<br/>
        /// Higher values result in answers that are more creative, lower values are more conservative.<br/>
        /// Can be any value between 0.0 and 1.0 inclusive.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
    }
}