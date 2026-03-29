//HintName: G.Models.RequestsThroughHeliconeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestsThroughHeliconeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestsThroughHelicone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequestsThroughHelicone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestsThroughHeliconeRequest" /> class.
        /// </summary>
        /// <param name="requestsThroughHelicone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestsThroughHeliconeRequest(
            bool requestsThroughHelicone)
        {
            this.RequestsThroughHelicone = requestsThroughHelicone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestsThroughHeliconeRequest" /> class.
        /// </summary>
        public RequestsThroughHeliconeRequest()
        {
        }
    }
}