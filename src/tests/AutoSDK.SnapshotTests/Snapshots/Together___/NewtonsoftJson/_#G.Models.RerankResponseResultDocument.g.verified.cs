//HintName: G.Models.RerankResponseResultDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankResponseResultDocument
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponseResultDocument" /> class.
        /// </summary>
        /// <param name="text"></param>
        public RerankResponseResultDocument(
            string? text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResponseResultDocument" /> class.
        /// </summary>
        public RerankResponseResultDocument()
        {
        }
    }
}