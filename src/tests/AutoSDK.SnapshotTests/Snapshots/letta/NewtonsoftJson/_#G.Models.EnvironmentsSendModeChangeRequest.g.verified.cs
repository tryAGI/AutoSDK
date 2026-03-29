//HintName: G.Models.EnvironmentsSendModeChangeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsSendModeChangeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EnvironmentsSendModeChangeRequestMode Mode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendModeChangeRequest" /> class.
        /// </summary>
        /// <param name="mode"></param>
        public EnvironmentsSendModeChangeRequest(
            global::G.EnvironmentsSendModeChangeRequestMode mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendModeChangeRequest" /> class.
        /// </summary>
        public EnvironmentsSendModeChangeRequest()
        {
        }
    }
}