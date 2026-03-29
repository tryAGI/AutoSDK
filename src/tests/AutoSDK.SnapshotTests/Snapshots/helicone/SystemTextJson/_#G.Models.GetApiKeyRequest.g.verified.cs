//HintName: G.Models.GetApiKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetApiKeyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionUUID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionUUID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyRequest" /> class.
        /// </summary>
        /// <param name="sessionUUID"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiKeyRequest(
            string sessionUUID)
        {
            this.SessionUUID = sessionUUID ?? throw new global::System.ArgumentNullException(nameof(sessionUUID));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyRequest" /> class.
        /// </summary>
        public GetApiKeyRequest()
        {
        }
    }
}