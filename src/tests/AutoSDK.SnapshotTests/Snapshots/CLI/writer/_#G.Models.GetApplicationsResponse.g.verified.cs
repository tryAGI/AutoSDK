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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ApplicationWithInputs> Data { get; set; }

        /// <summary>
        /// UUID of the first application in the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public global::System.Guid? FirstId { get; set; }

        /// <summary>
        /// UUID of the last application in the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public global::System.Guid? LastId { get; set; }

        /// <summary>
        /// Indicates if there are more results available in subsequent pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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