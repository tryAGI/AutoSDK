//HintName: G.Models.StateBackfillJobListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StateBackfillJobListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jobs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.StateBackfillJobItemResponse> Jobs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillJobListResponse" /> class.
        /// </summary>
        /// <param name="jobs"></param>
        public StateBackfillJobListResponse(
            global::System.Collections.Generic.IList<global::G.StateBackfillJobItemResponse> jobs)
        {
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateBackfillJobListResponse" /> class.
        /// </summary>
        public StateBackfillJobListResponse()
        {
        }
    }
}