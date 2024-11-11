//HintName: G.Models.ListJobsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListJobsResponse
    {
        /// <summary>
        /// An array of jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public global::System.Collections.Generic.IList<global::G.Job>? Jobs { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListJobsResponse" /> class.
        /// </summary>
        /// <param name="jobs">
        /// An array of jobs.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListJobsResponse(
            global::System.Collections.Generic.IList<global::G.Job>? jobs,
            global::G.ListMetadata? metadata)
        {
            this.Jobs = jobs;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListJobsResponse" /> class.
        /// </summary>
        public ListJobsResponse()
        {
        }
    }
}