//HintName: G.Models.ListPaginatedFineTuningJobsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListPaginatedFineTuningJobsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FineTuningJob> Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ListPaginatedFineTuningJobsResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPaginatedFineTuningJobsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hasMore"></param>
        /// <param name="object"></param>
        public ListPaginatedFineTuningJobsResponse(
            global::System.Collections.Generic.IList<global::G.FineTuningJob> data,
            bool hasMore,
            global::G.ListPaginatedFineTuningJobsResponseObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPaginatedFineTuningJobsResponse" /> class.
        /// </summary>
        public ListPaginatedFineTuningJobsResponse()
        {
        }
    }
}