//HintName: G.Models.ExperimentItemStreamRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItemStreamRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_retrieved_id")]
        public global::System.Guid? LastRetrievedId { get; set; }

        /// <summary>
        /// Truncate image included in either input, output or metadata<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncate")]
        public bool? Truncate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemStreamRequest" /> class.
        /// </summary>
        /// <param name="experimentName"></param>
        /// <param name="limit"></param>
        /// <param name="lastRetrievedId"></param>
        /// <param name="truncate">
        /// Truncate image included in either input, output or metadata<br/>
        /// Default Value: true
        /// </param>
        /// <param name="projectName"></param>
        public ExperimentItemStreamRequest(
            string experimentName,
            int? limit,
            global::System.Guid? lastRetrievedId,
            bool? truncate,
            string? projectName)
        {
            this.ExperimentName = experimentName ?? throw new global::System.ArgumentNullException(nameof(experimentName));
            this.Limit = limit;
            this.LastRetrievedId = lastRetrievedId;
            this.Truncate = truncate;
            this.ProjectName = projectName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemStreamRequest" /> class.
        /// </summary>
        public ExperimentItemStreamRequest()
        {
        }
    }
}