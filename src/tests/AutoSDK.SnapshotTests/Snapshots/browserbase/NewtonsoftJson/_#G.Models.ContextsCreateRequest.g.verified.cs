//HintName: G.Models.ContextsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextsCreateRequest
    {
        /// <summary>
        /// The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextsCreateRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.
        /// </param>
        public ContextsCreateRequest(
            string? projectId)
        {
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextsCreateRequest" /> class.
        /// </summary>
        public ContextsCreateRequest()
        {
        }
    }
}