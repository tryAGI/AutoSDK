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
        [global::System.Text.Json.Serialization.JsonPropertyName("tables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TableStatsRow> Tables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableQueryStatsBatchRes" /> class.
        /// </summary>
        /// <param name="tables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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