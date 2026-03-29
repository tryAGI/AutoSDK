//HintName: G.Models.TranscriptionConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfig" /> class.
        /// </summary>
        /// <param name="language"></param>
        public TranscriptionConfig(
            string? language)
        {
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionConfig" /> class.
        /// </summary>
        public TranscriptionConfig()
        {
        }
    }
}