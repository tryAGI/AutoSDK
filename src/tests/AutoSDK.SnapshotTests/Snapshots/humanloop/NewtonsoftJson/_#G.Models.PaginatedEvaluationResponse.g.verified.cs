//HintName: G.Models.PaginatedEvaluationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedEvaluationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("records", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvaluationResponse> Records { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page", Required = global::Newtonsoft.Json.Required.Always)]
        public int Page { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="PaginatedEvaluationResponse" /> class.
        /// </summary>
        /// <param name="records"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="total"></param>
        public PaginatedEvaluationResponse(
            global::System.Collections.Generic.IList<global::G.EvaluationResponse> records,
            int page,
            int size,
            int total)
        {
            this.Records = records ?? throw new global::System.ArgumentNullException(nameof(records));
            this.Page = page;
            this.Size = size;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedEvaluationResponse" /> class.
        /// </summary>
        public PaginatedEvaluationResponse()
        {
        }
    }
}