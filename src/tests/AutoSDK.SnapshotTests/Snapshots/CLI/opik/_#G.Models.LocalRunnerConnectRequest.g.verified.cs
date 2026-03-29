//HintName: G.Models.LocalRunnerConnectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalRunnerConnectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pairing_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PairingCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunnerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerConnectRequest" /> class.
        /// </summary>
        /// <param name="pairingCode"></param>
        /// <param name="runnerName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalRunnerConnectRequest(
            string pairingCode,
            string runnerName)
        {
            this.PairingCode = pairingCode ?? throw new global::System.ArgumentNullException(nameof(pairingCode));
            this.RunnerName = runnerName ?? throw new global::System.ArgumentNullException(nameof(runnerName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerConnectRequest" /> class.
        /// </summary>
        public LocalRunnerConnectRequest()
        {
        }
    }
}