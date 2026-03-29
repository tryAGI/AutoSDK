//HintName: G.Models.ClickHouseTableColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClickHouseTableColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_type")]
        public string? DefaultType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_expression")]
        public string? DefaultExpression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("codec_expression")]
        public string? CodecExpression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttl_expression")]
        public string? TtlExpression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickHouseTableColumn" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="defaultType"></param>
        /// <param name="defaultExpression"></param>
        /// <param name="comment"></param>
        /// <param name="codecExpression"></param>
        /// <param name="ttlExpression"></param>
        public ClickHouseTableColumn(
            string name,
            string type,
            string? defaultType,
            string? defaultExpression,
            string? comment,
            string? codecExpression,
            string? ttlExpression)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DefaultType = defaultType;
            this.DefaultExpression = defaultExpression;
            this.Comment = comment;
            this.CodecExpression = codecExpression;
            this.TtlExpression = ttlExpression;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickHouseTableColumn" /> class.
        /// </summary>
        public ClickHouseTableColumn()
        {
        }
    }
}