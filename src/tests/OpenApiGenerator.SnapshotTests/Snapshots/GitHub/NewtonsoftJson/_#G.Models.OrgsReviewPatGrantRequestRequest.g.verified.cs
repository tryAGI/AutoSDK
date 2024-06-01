//HintName: G.Models.OrgsReviewPatGrantRequestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsReviewPatGrantRequestRequest
    {
        /// <summary>
        /// Action to apply to the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public OrgsReviewPatGrantRequestRequestAction Action { get; set; } = default!;

        /// <summary>
        /// Reason for approving or denying the request. Max 1024 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}