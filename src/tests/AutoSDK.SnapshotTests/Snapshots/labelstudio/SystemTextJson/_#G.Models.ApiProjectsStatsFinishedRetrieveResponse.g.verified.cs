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
        [global::System.Text.Json.Serialization.JsonPropertyName("finished")]
        public int? Finished { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Progress percentage (0-100)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public int? Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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