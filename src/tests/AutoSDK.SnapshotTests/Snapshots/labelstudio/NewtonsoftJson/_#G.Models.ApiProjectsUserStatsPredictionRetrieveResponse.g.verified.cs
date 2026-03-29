//HintName: G.Models.ApiProjectsUserStatsPredictionRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsUserStatsPredictionRetrieveResponse
    {
        /// <summary>
        /// Dictionary mapping user IDs to their prediction agreement scores
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agreement")]
        public object? Agreement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsUserStatsPredictionRetrieveResponse" /> class.
        /// </summary>
        /// <param name="agreement">
        /// Dictionary mapping user IDs to their prediction agreement scores
        /// </param>
        public ApiProjectsUserStatsPredictionRetrieveResponse(
            object? agreement)
        {
            this.Agreement = agreement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsUserStatsPredictionRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsUserStatsPredictionRetrieveResponse()
        {
        }
    }
}