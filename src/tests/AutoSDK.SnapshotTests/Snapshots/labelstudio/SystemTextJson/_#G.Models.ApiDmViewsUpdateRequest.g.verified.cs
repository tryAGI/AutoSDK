//HintName: G.Models.ApiDmViewsUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiDmViewsUpdateRequest
    {
        /// <summary>
        /// Custom view data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::G.ApiDmViewsUpdateRequestData? Data { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmViewsUpdateRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// Custom view data
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiDmViewsUpdateRequest(
            global::G.ApiDmViewsUpdateRequestData? data,
            int? project)
        {
            this.Data = data;
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmViewsUpdateRequest" /> class.
        /// </summary>
        public ApiDmViewsUpdateRequest()
        {
        }
    }
}