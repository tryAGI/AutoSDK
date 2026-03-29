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
        [global::Newtonsoft.Json.JsonProperty("rowCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double RowCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public double Size { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("elapsedMilliseconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double ElapsedMilliseconds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rows", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RecordStringAny> Rows { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteSqlResponse" /> class.
        /// </summary>
        /// <param name="rowCount"></param>
        /// <param name="size"></param>
        /// <param name="elapsedMilliseconds"></param>
        /// <param name="rows"></param>
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