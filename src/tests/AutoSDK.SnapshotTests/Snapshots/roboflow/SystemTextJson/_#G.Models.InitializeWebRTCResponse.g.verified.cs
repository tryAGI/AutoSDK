//HintName: G.Models.InitializeWebRTCResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitializeWebRTCResponse
    {
        /// <summary>
        /// Operation status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Context of the command.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CommandContext Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sdp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitializeWebRTCResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Operation status
        /// </param>
        /// <param name="context">
        /// Context of the command.
        /// </param>
        /// <param name="sdp"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitializeWebRTCResponse(
            string status,
            global::G.CommandContext context,
            string sdp,
            string type)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.Sdp = sdp ?? throw new global::System.ArgumentNullException(nameof(sdp));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitializeWebRTCResponse" /> class.
        /// </summary>
        public InitializeWebRTCResponse()
        {
        }
    }
}