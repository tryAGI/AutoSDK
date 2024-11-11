//HintName: G.Models.Text.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Text
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineIds")]
        public global::System.Collections.Generic.IList<string>? PipelineIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transformedContent")]
        public string? TransformedContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transformedContentChunkNum")]
        public int? TransformedContentChunkNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transformedContentTokenNum")]
        public int? TransformedContentTokenNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transformedContentUpdateTime")]
        public global::System.DateTime? TransformedContentUpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Text" /> class.
        /// </summary>
        /// <param name="pipelineIds"></param>
        /// <param name="transformedContent"></param>
        /// <param name="transformedContentChunkNum"></param>
        /// <param name="transformedContentTokenNum"></param>
        /// <param name="transformedContentUpdateTime"></param>
        public Text(
            global::System.Collections.Generic.IList<string>? pipelineIds,
            string? transformedContent,
            int? transformedContentChunkNum,
            int? transformedContentTokenNum,
            global::System.DateTime? transformedContentUpdateTime)
        {
            this.PipelineIds = pipelineIds;
            this.TransformedContent = transformedContent;
            this.TransformedContentChunkNum = transformedContentChunkNum;
            this.TransformedContentTokenNum = transformedContentTokenNum;
            this.TransformedContentUpdateTime = transformedContentUpdateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Text" /> class.
        /// </summary>
        public Text()
        {
        }
    }
}