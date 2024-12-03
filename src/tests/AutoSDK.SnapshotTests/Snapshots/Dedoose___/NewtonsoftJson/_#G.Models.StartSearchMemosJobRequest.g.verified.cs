//HintName: G.Models.StartSearchMemosJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartSearchMemosJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchText", Required = global::Newtonsoft.Json.Required.Always)]
        public string SearchText { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartSearchMemosJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="searchText"></param>
        public StartSearchMemosJobRequest(
            global::System.Guid projectId,
            string searchText)
        {
            this.ProjectId = projectId;
            this.SearchText = searchText ?? throw new global::System.ArgumentNullException(nameof(searchText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartSearchMemosJobRequest" /> class.
        /// </summary>
        public StartSearchMemosJobRequest()
        {
        }
    }
}