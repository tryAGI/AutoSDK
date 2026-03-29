//HintName: G.Models.GetApplicationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response object containing a paginated list of applications.
    /// </summary>
    public sealed partial class GetApplicationsResponse
    {
        /// <summary>
        /// List of application objects with their configurations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ApplicationWithInputs> Data { get; set; } = default!;

        /// <summary>
        /// UUID of the first application in the current page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_id")]
        public global::System.Guid? FirstId { get; set; }

        /// <summary>
        /// UUID of the last application in the current page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_id")]
        public global::System.Guid? LastId { get; set; }

        /// <summary>
        /// Indicates if there are more results available in subsequent pages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApplicationsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of application objects with their configurations.
        /// </param>
        /// <param name="hasMore">
        /// Indicates if there are more results available in subsequent pages.
        /// </param>
        /// <param name="firstId">
        /// UUID of the first application in the current page.
        /// </param>
        /// <param name="lastId">
        /// UUID of the last application in the current page.
        /// </param>
        public GetApplicationsResponse(
            global::System.Collections.Generic.IList<global::G.ApplicationWithInputs> data,
            bool hasMore,
            global::System.Guid? firstId,
            global::System.Guid? lastId)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.LastId = lastId;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApplicationsResponse" /> class.
        /// </summary>
        public GetApplicationsResponse()
        {
        }
    }
}