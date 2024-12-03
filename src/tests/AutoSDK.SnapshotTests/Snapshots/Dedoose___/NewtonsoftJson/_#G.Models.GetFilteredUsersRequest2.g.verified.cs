//HintName: G.Models.GetFilteredUsersRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFilteredUsersRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxResults", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxResults { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilteredUsersRequest2" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
        public GetFilteredUsersRequest2(
            global::System.Guid projectId,
            string filter,
            int maxResults)
        {
            this.ProjectId = projectId;
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilteredUsersRequest2" /> class.
        /// </summary>
        public GetFilteredUsersRequest2()
        {
        }
    }
}