//HintName: G.Models.ListLabelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListLabelsResponse
    {
        /// <summary>
        /// Total number of labels
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.Label>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLabelsResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of labels
        /// </param>
        /// <param name="data"></param>
        public ListLabelsResponse(
            int? total,
            global::System.Collections.Generic.IList<global::G.Label>? data)
        {
            this.Total = total;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLabelsResponse" /> class.
        /// </summary>
        public ListLabelsResponse()
        {
        }
    }
}