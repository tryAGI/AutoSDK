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
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrgsReviewPatGrantRequestRequestActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrgsReviewPatGrantRequestRequestAction Action { get; set; }

        /// <summary>
        /// Reason for approving or denying the request. Max 1024 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsReviewPatGrantRequestRequest" /> class.
        /// </summary>
        /// <param name="action">
        /// Action to apply to the request.
        /// </param>
        /// <param name="reason">
        /// Reason for approving or denying the request. Max 1024 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsReviewPatGrantRequestRequest(
            global::G.OrgsReviewPatGrantRequestRequestAction action,
            string? reason)
        {
            this.Action = action;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsReviewPatGrantRequestRequest" /> class.
        /// </summary>
        public OrgsReviewPatGrantRequestRequest()
        {
        }
    }
}