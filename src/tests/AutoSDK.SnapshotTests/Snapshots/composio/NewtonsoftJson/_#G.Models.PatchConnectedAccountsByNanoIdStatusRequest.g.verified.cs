//HintName: G.Models.PatchConnectedAccountsByNanoIdStatusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"enabled":true}
    /// </summary>
    public sealed partial class PatchConnectedAccountsByNanoIdStatusRequest
    {
        /// <summary>
        /// Set to true to enable the account or false to disable it
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountsByNanoIdStatusRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Set to true to enable the account or false to disable it
        /// </param>
        public PatchConnectedAccountsByNanoIdStatusRequest(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountsByNanoIdStatusRequest" /> class.
        /// </summary>
        public PatchConnectedAccountsByNanoIdStatusRequest()
        {
        }
    }
}