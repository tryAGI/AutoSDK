//HintName: G.Models.SessionsUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsUpdateRequest
    {
        /// <summary>
        /// The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Set to `REQUEST_RELEASE` to request that the session complete. Use before session's timeout to avoid additional charges.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.SessionsUpdateRequestStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsUpdateRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The Project ID. Can be found in [Settings](https://www.browserbase.com/settings). Optional - if not provided, the project will be inferred from the API key.
        /// </param>
        /// <param name="status">
        /// Set to `REQUEST_RELEASE` to request that the session complete. Use before session's timeout to avoid additional charges.
        /// </param>
        public SessionsUpdateRequest(
            string? projectId,
            global::G.SessionsUpdateRequestStatus status)
        {
            this.ProjectId = projectId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsUpdateRequest" /> class.
        /// </summary>
        public SessionsUpdateRequest()
        {
        }
    }
}