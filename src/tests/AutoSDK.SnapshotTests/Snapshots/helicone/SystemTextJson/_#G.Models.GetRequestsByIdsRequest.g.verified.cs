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
        [global::System.Text.Json.Serialization.JsonPropertyName("requestIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RequestIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestsByIdsRequest" /> class.
        /// </summary>
        /// <param name="requestIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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