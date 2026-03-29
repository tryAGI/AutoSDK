//HintName: G.Models.ApiProjectsStatsFinishedRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsFinishedRetrieveResponse
    {
        /// <summary>
        /// Number of finished tasks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished")]
        public int? Finished { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Progress percentage (0-100)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress")]
        public int? Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsFinishedRetrieveResponse" /> class.
        /// </summary>
        /// <param name="finished">
        /// Number of finished tasks
        /// </param>
        /// <param name="id">
        /// User ID
        /// </param>
        /// <param name="progress">
        /// Progress percentage (0-100)
        /// </param>
        public ApiProjectsStatsFinishedRetrieveResponse(
            int? finished,
            int? id,
            int? progress)
        {
            this.Finished = finished;
            this.Id = id;
            this.Progress = progress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsFinishedRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsStatsFinishedRetrieveResponse()
        {
        }
    }
}