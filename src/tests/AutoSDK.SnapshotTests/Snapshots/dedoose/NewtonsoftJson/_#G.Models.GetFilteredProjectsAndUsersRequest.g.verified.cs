//HintName: G.Models.GetFilteredProjectsAndUsersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFilteredProjectsAndUsersRequest
    {
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
        /// Initializes a new instance of the <see cref="GetFilteredProjectsAndUsersRequest" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
        public GetFilteredProjectsAndUsersRequest(
            string filter,
            int maxResults)
        {
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
            this.MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilteredProjectsAndUsersRequest" /> class.
        /// </summary>
        public GetFilteredProjectsAndUsersRequest()
        {
        }
    }
}