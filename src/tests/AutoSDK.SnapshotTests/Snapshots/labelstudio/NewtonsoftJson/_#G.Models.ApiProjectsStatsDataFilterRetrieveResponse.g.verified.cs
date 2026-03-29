//HintName: G.Models.ApiProjectsStatsDataFilterRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsDataFilterRetrieveResponse
    {
        /// <summary>
        /// Data filter statistics by user and model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_filters")]
        public global::G.ApiProjectsStatsDataFilterRetrieveResponseUserFilters? UserFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsDataFilterRetrieveResponse" /> class.
        /// </summary>
        /// <param name="userFilters">
        /// Data filter statistics by user and model
        /// </param>
        public ApiProjectsStatsDataFilterRetrieveResponse(
            global::G.ApiProjectsStatsDataFilterRetrieveResponseUserFilters? userFilters)
        {
            this.UserFilters = userFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsDataFilterRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsStatsDataFilterRetrieveResponse()
        {
        }
    }
}