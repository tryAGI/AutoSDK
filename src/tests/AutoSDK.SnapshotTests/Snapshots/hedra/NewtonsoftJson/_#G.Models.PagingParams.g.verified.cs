//HintName: G.Models.PagingParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PagingParams
    {
        /// <summary>
        /// Number of items returned in the page.<br/>
        /// Default Value: 100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Number of records skipped.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingParams" /> class.
        /// </summary>
        /// <param name="limit">
        /// Number of items returned in the page.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Number of records skipped.<br/>
        /// Default Value: 0
        /// </param>
        public PagingParams(
            int? limit,
            int? offset)
        {
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingParams" /> class.
        /// </summary>
        public PagingParams()
        {
        }
    }
}