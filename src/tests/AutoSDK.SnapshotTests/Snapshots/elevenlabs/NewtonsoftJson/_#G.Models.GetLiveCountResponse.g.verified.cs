//HintName: G.Models.GetLiveCountResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLiveCountResponse
    {
        /// <summary>
        /// The number of active ongoing conversations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLiveCountResponse" /> class.
        /// </summary>
        /// <param name="count">
        /// The number of active ongoing conversations.
        /// </param>
        public GetLiveCountResponse(
            int count)
        {
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLiveCountResponse" /> class.
        /// </summary>
        public GetLiveCountResponse()
        {
        }
    }
}