//HintName: G.Models.TelephonyCallConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelephonyCallConfig
    {
        /// <summary>
        /// How long to ring the recipient before giving up, in seconds. Note that this will also be limited by the provider's own constraints.<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ringing_timeout_secs")]
        public int? RingingTimeoutSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyCallConfig" /> class.
        /// </summary>
        /// <param name="ringingTimeoutSecs">
        /// How long to ring the recipient before giving up, in seconds. Note that this will also be limited by the provider's own constraints.<br/>
        /// Default Value: 60
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelephonyCallConfig(
            int? ringingTimeoutSecs)
        {
            this.RingingTimeoutSecs = ringingTimeoutSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyCallConfig" /> class.
        /// </summary>
        public TelephonyCallConfig()
        {
        }
    }
}