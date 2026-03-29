//HintName: G.Models.LocalRunnerPairResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalRunnerPairResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pairing_code")]
        public string? PairingCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_id")]
        public global::System.Guid? RunnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in_seconds")]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerPairResponse" /> class.
        /// </summary>
        /// <param name="pairingCode"></param>
        /// <param name="runnerId"></param>
        /// <param name="expiresInSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalRunnerPairResponse(
            string? pairingCode,
            global::System.Guid? runnerId,
            int? expiresInSeconds)
        {
            this.PairingCode = pairingCode;
            this.RunnerId = runnerId;
            this.ExpiresInSeconds = expiresInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerPairResponse" /> class.
        /// </summary>
        public LocalRunnerPairResponse()
        {
        }
    }
}