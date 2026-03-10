//HintName: G.Models.SoftTimeoutConfigOverrideConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SoftTimeoutConfigOverrideConfig
    {
        /// <summary>
        /// Whether to allow overriding the message field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public bool? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfigOverrideConfig" /> class.
        /// </summary>
        /// <param name="message">
        /// Whether to allow overriding the message field.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SoftTimeoutConfigOverrideConfig(
            bool? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfigOverrideConfig" /> class.
        /// </summary>
        public SoftTimeoutConfigOverrideConfig()
        {
        }
    }
}