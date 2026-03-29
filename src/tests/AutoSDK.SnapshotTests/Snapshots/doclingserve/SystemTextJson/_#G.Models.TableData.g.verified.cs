//HintName: G.Models.TableData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// BaseTableData.
    /// </summary>
    public sealed partial class TableData
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_cells")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.RichTableCell, global::G.TableCell>>? TableCells { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_rows")]
        public int? NumRows { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_cols")]
        public int? NumCols { get; set; }

        /// <summary>
        /// grid.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("grid")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.TableCell>> Grid { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableData" /> class.
        /// </summary>
        /// <param name="tableCells">
        /// Default Value: []
        /// </param>
        /// <param name="numRows">
        /// Default Value: 0
        /// </param>
        /// <param name="numCols">
        /// Default Value: 0
        /// </param>
        /// <param name="grid">
        /// grid.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableData(
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.RichTableCell, global::G.TableCell>>? tableCells,
            int? numRows,
            int? numCols,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.TableCell>> grid = default!)
        {
            this.TableCells = tableCells;
            this.NumRows = numRows;
            this.NumCols = numCols;
            this.Grid = grid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableData" /> class.
        /// </summary>
        public TableData()
        {
        }
    }
}