//HintName: G.Models.GetGroupResponseTranslationTranscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGroupResponseTranslationTranscription
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
        public global::G.GetGroupResponseTranslationTranscriptionVersion Version { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="GetGroupResponseTranslationTranscription" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="version"></param>
        /// <param name="selected"></param>
        public GetGroupResponseTranslationTranscription(
            string url,
            global::G.GetGroupResponseTranslationTranscriptionVersion version,
            bool? selected)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Version = version;
            this.Selected = selected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGroupResponseTranslationTranscription" /> class.
        /// </summary>
        public GetGroupResponseTranslationTranscription()
        {
        }
    }
}