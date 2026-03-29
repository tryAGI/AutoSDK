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
        [global::System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string? Desc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format_type")]
        public int? FormatType { get; set; }

        /// <summary>
        /// 火山侧知识库id 字符串
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 火山知识库详情链接
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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