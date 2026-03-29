//HintName: G.Models.AlertFilterDisconnectionReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Disconnection reasons to filter on.
    /// </summary>
    public sealed partial class AlertFilterDisconnectionReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<global::G.DisconnectionReason4>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertFilterDisconnectionReason" /> class.
        /// </summary>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertFilterDisconnectionReason(
            global::System.Collections.Generic.IList<global::G.DisconnectionReason4>? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertFilterDisconnectionReason" /> class.
        /// </summary>
        public AlertFilterDisconnectionReason()
        {
        }
    }
}