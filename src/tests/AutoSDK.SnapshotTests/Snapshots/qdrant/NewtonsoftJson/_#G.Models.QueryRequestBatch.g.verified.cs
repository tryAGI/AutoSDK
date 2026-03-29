//HintName: G.Models.QueryRequestBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryRequestBatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searches", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.QueryRequest> Searches { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequestBatch" /> class.
        /// </summary>
        /// <param name="searches"></param>
        public QueryRequestBatch(
            global::System.Collections.Generic.IList<global::G.QueryRequest> searches)
        {
            this.Searches = searches ?? throw new global::System.ArgumentNullException(nameof(searches));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequestBatch" /> class.
        /// </summary>
        public QueryRequestBatch()
        {
        }
    }
}