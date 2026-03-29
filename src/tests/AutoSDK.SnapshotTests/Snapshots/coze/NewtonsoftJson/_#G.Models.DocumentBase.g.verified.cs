//HintName: G.Models.DocumentBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentBase
    {
        /// <summary>
        /// 图片类型，人工标注时的图片描述，目前只支持openapi调用
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SourceInfo SourceInfo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_rule")]
        public global::G.UpdateRule? UpdateRule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBase" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sourceInfo"></param>
        /// <param name="caption">
        /// 图片类型，人工标注时的图片描述，目前只支持openapi调用
        /// </param>
        /// <param name="updateRule"></param>
        public DocumentBase(
            string name,
            global::G.SourceInfo sourceInfo,
            string? caption,
            global::G.UpdateRule? updateRule)
        {
            this.Caption = caption;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SourceInfo = sourceInfo ?? throw new global::System.ArgumentNullException(nameof(sourceInfo));
            this.UpdateRule = updateRule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBase" /> class.
        /// </summary>
        public DocumentBase()
        {
        }
    }
}