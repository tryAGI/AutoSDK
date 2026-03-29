//HintName: G.Models.TableQueryStatsBatchRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableQueryStatsBatchRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tables", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TableStatsRow> Tables { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableQueryStatsBatchRes" /> class.
        /// </summary>
        /// <param name="tables"></param>
        public TableQueryStatsBatchRes(
            global::System.Collections.Generic.IList<global::G.TableStatsRow> tables)
        {
            this.Tables = tables ?? throw new global::System.ArgumentNullException(nameof(tables));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableQueryStatsBatchRes" /> class.
        /// </summary>
        public TableQueryStatsBatchRes()
        {
        }
    }
}