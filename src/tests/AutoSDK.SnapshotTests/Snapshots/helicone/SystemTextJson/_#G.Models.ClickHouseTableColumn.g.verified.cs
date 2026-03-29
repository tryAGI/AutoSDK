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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_type")]
        public string? DefaultType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_expression")]
        public string? DefaultExpression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codec_expression")]
        public string? CodecExpression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_expression")]
        public string? TtlExpression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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