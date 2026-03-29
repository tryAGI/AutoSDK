//HintName: G.Models.GetRequestsByIdsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRequestsByIdsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RequestIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestsByIdsRequest" /> class.
        /// </summary>
        /// <param name="requestIds"></param>
        public GetRequestsByIdsRequest(
            global::System.Collections.Generic.IList<string> requestIds)
        {
            this.RequestIds = requestIds ?? throw new global::System.ArgumentNullException(nameof(requestIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestsByIdsRequest" /> class.
        /// </summary>
        public GetRequestsByIdsRequest()
        {
        }
    }
}