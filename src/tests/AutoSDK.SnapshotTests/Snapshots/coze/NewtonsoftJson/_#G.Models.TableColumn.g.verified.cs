//HintName: G.Models.TableColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableColumn
    {
        /// <summary>
        /// 列名
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_name")]
        public string? ColumnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_type")]
        public int? ColumnType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contains_empty_value")]
        public bool? ContainsEmptyValue { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("desc")]
        public string? Desc { get; set; }

        /// <summary>
        /// 列 id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 是否为语义匹配列
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_semantic")]
        public bool? IsSemantic { get; set; }

        /// <summary>
        /// 列原本在 excel 的序号
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence")]
        public string? Sequence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableColumn" /> class.
        /// </summary>
        /// <param name="columnName">
        /// 列名
        /// </param>
        /// <param name="columnType"></param>
        /// <param name="containsEmptyValue"></param>
        /// <param name="desc">
        /// 描述
        /// </param>
        /// <param name="id">
        /// 列 id
        /// </param>
        /// <param name="isSemantic">
        /// 是否为语义匹配列
        /// </param>
        /// <param name="sequence">
        /// 列原本在 excel 的序号
        /// </param>
        public TableColumn(
            string? columnName,
            int? columnType,
            bool? containsEmptyValue,
            string? desc,
            string? id,
            bool? isSemantic,
            string? sequence)
        {
            this.ColumnName = columnName;
            this.ColumnType = columnType;
            this.ContainsEmptyValue = containsEmptyValue;
            this.Desc = desc;
            this.Id = id;
            this.IsSemantic = isSemantic;
            this.Sequence = sequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableColumn" /> class.
        /// </summary>
        public TableColumn()
        {
        }
    }
}