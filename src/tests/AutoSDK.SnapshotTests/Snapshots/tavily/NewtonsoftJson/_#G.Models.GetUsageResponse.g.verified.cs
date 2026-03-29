//HintName: G.Models.GetUsageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public global::G.GetUsageResponseKey? Key { get; set; }

        /// <summary>
        /// Account plan and usage information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account")]
        public global::G.GetUsageResponseAccount? Account { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponse" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="account">
        /// Account plan and usage information
        /// </param>
        public GetUsageResponse(
            global::G.GetUsageResponseKey? key,
            global::G.GetUsageResponseAccount? account)
        {
            this.Key = key;
            this.Account = account;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponse" /> class.
        /// </summary>
        public GetUsageResponse()
        {
        }
    }
}