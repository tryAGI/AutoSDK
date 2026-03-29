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
        [global::Newtonsoft.Json.JsonProperty("pairing_code")]
        public string? PairingCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_id")]
        public global::System.Guid? RunnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_in_seconds")]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerPairResponse" /> class.
        /// </summary>
        /// <param name="pairingCode"></param>
        /// <param name="runnerId"></param>
        /// <param name="expiresInSeconds"></param>
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