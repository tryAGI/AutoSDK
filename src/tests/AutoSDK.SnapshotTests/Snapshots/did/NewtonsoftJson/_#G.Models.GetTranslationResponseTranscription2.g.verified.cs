//HintName: G.Models.GetTranslationResponseTranscription2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTranslationResponseTranscription2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetTranslationResponseTranscriptionVersion2 Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected")]
        public bool? Selected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranslationResponseTranscription2" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="version"></param>
        /// <param name="selected"></param>
        public GetTranslationResponseTranscription2(
            string url,
            global::G.GetTranslationResponseTranscriptionVersion2 version,
            bool? selected)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Version = version;
            this.Selected = selected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranslationResponseTranscription2" /> class.
        /// </summary>
        public GetTranslationResponseTranscription2()
        {
        }
    }
}