//HintName: G.Models.SourceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SourceTypeEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("civit_url")]
        public string? CivitUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="civitUrl"></param>
        public SourceModel(
            global::G.SourceTypeEnum type,
            string? civitUrl)
        {
            this.Type = type;
            this.CivitUrl = civitUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> class.
        /// </summary>
        public SourceModel()
        {
        }
    }
}