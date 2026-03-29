//HintName: G.Models.VolcanoDataset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VolcanoDataset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("desc")]
        public string? Desc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format_type")]
        public int? FormatType { get; set; }

        /// <summary>
        /// 火山侧知识库id 字符串
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 火山知识库详情链接
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("link")]
        public string? Link { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolcanoDataset" /> class.
        /// </summary>
        /// <param name="desc"></param>
        /// <param name="formatType"></param>
        /// <param name="id">
        /// 火山侧知识库id 字符串
        /// </param>
        /// <param name="link">
        /// 火山知识库详情链接
        /// </param>
        /// <param name="name">
        /// 名称
        /// </param>
        /// <param name="status"></param>
        public VolcanoDataset(
            string? desc,
            int? formatType,
            string? id,
            string? link,
            string? name,
            int? status)
        {
            this.Desc = desc;
            this.FormatType = formatType;
            this.Id = id;
            this.Link = link;
            this.Name = name;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolcanoDataset" /> class.
        /// </summary>
        public VolcanoDataset()
        {
        }
    }
}