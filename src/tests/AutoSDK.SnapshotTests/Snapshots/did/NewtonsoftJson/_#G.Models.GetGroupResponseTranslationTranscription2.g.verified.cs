//HintName: G.Models.GetGroupResponseTranslationTranscription2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGroupResponseTranslationTranscription2
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
        public global::G.GetGroupResponseTranslationTranscriptionVersion2 Version { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="GetGroupResponseTranslationTranscription2" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="version"></param>
        /// <param name="selected"></param>
        public GetGroupResponseTranslationTranscription2(
            string url,
            global::G.GetGroupResponseTranslationTranscriptionVersion2 version,
            bool? selected)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Version = version;
            this.Selected = selected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGroupResponseTranslationTranscription2" /> class.
        /// </summary>
        public GetGroupResponseTranslationTranscription2()
        {
        }
    }
}