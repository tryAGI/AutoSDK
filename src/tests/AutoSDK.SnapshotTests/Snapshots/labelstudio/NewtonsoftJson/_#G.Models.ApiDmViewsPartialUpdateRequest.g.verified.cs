//HintName: G.Models.ApiDmViewsPartialUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiDmViewsPartialUpdateRequest
    {
        /// <summary>
        /// Custom view data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.ApiDmViewsPartialUpdateRequestData? Data { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmViewsPartialUpdateRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// Custom view data
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        public ApiDmViewsPartialUpdateRequest(
            global::G.ApiDmViewsPartialUpdateRequestData? data,
            int? project)
        {
            this.Data = data;
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmViewsPartialUpdateRequest" /> class.
        /// </summary>
        public ApiDmViewsPartialUpdateRequest()
        {
        }
    }
}