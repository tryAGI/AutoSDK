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
        [global::Newtonsoft.Json.JsonProperty("pairing_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string PairingCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string RunnerName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerConnectRequest" /> class.
        /// </summary>
        /// <param name="pairingCode"></param>
        /// <param name="runnerName"></param>
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