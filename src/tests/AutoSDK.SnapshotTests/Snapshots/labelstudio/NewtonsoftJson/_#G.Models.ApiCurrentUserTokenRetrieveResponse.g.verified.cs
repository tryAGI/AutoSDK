//HintName: G.Models.ApiCurrentUserTokenRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiCurrentUserTokenRetrieveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiCurrentUserTokenRetrieveResponse" /> class.
        /// </summary>
        /// <param name="detail"></param>
        public ApiCurrentUserTokenRetrieveResponse(
            string? detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiCurrentUserTokenRetrieveResponse" /> class.
        /// </summary>
        public ApiCurrentUserTokenRetrieveResponse()
        {
        }
    }
}