//HintName: G.Models.RealtimeTemporaryTokenResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"token":"fe4145dd1e7a2e149488dcd2d553a8018a89833fc5084837d66fd1bcf5a105d4"}
    /// </summary>
    public sealed partial class RealtimeTemporaryTokenResponse
    {
        /// <summary>
        /// The temporary authentication token for Streaming Speech-to-Text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTemporaryTokenResponse" /> class.
        /// </summary>
        /// <param name="token">
        /// The temporary authentication token for Streaming Speech-to-Text
        /// </param>
        public RealtimeTemporaryTokenResponse(
            string token)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTemporaryTokenResponse" /> class.
        /// </summary>
        public RealtimeTemporaryTokenResponse()
        {
        }
    }
}