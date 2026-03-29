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
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EnvironmentsSendModeChangeRequestModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EnvironmentsSendModeChangeRequestMode Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendModeChangeRequest" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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