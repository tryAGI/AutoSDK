//HintName: G.Models.GetUserActiveExtensionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserActiveExtensionsResponse
    {
        /// <summary>
        /// The active extensions that the broadcaster has installed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public GetUserActiveExtensionsResponseData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}