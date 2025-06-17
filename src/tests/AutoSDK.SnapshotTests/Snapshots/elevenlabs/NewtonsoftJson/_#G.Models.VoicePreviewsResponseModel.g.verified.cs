//HintName: G.Models.VoicePreviewsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicePreviewsResponseModel
    {
        /// <summary>
        /// The previews of the generated voices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previews", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VoicePreviewResponseModel> Previews { get; set; } = default!;

        /// <summary>
        /// The text used to preview the voices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePreviewsResponseModel" /> class.
        /// </summary>
        /// <param name="previews">
        /// The previews of the generated voices.
        /// </param>
        /// <param name="text">
        /// The text used to preview the voices.
        /// </param>
        public VoicePreviewsResponseModel(
            global::System.Collections.Generic.IList<global::G.VoicePreviewResponseModel> previews,
            string text)
        {
            this.Previews = previews ?? throw new global::System.ArgumentNullException(nameof(previews));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePreviewsResponseModel" /> class.
        /// </summary>
        public VoicePreviewsResponseModel()
        {
        }
    }
}