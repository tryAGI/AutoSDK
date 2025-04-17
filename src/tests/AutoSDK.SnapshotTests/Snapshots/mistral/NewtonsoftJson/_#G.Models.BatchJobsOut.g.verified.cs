//HintName: G.Models.BatchJobsOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchJobsOut
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.BatchJobOut>? Data { get; set; }

        /// <summary>
        /// Default Value: list
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.BatchJobsOutObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobsOut" /> class.
        /// </summary>
        /// <param name="data">
        /// Default Value: []
        /// </param>
        /// <param name="object">
        /// Default Value: list
        /// </param>
        /// <param name="total"></param>
        public BatchJobsOut(
            int total,
            global::System.Collections.Generic.IList<global::G.BatchJobOut>? data,
            global::G.BatchJobsOutObject? @object)
        {
            this.Total = total;
            this.Data = data;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobsOut" /> class.
        /// </summary>
        public BatchJobsOut()
        {
        }
    }
}