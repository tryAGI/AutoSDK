//HintName: G.Models.FallbackCartesiaTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackCartesiaTranscriber
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.FallbackCartesiaTranscriberProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.FallbackCartesiaTranscriberModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public global::G.FallbackCartesiaTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCartesiaTranscriber" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="model"></param>
        /// <param name="language"></param>
        public FallbackCartesiaTranscriber(
            global::G.FallbackCartesiaTranscriberProvider provider,
            global::G.FallbackCartesiaTranscriberModel? model,
            global::G.FallbackCartesiaTranscriberLanguage? language)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackCartesiaTranscriber" /> class.
        /// </summary>
        public FallbackCartesiaTranscriber()
        {
        }
    }
}