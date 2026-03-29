//HintName: G.Models.ExecuteSqlResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteSqlResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RowCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsedMilliseconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ElapsedMilliseconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RecordStringAny> Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteSqlResponse" /> class.
        /// </summary>
        /// <param name="rowCount"></param>
        /// <param name="size"></param>
        /// <param name="elapsedMilliseconds"></param>
        /// <param name="rows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteSqlResponse(
            double rowCount,
            double size,
            double elapsedMilliseconds,
            global::System.Collections.Generic.IList<global::G.RecordStringAny> rows)
        {
            this.RowCount = rowCount;
            this.Size = size;
            this.ElapsedMilliseconds = elapsedMilliseconds;
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteSqlResponse" /> class.
        /// </summary>
        public ExecuteSqlResponse()
        {
        }
    }
}