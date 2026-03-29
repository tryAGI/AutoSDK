//HintName: G.Models.EnvironmentsRegisterResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsRegisterResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wsUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsRegisterResponse" /> class.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="wsUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentsRegisterResponse(
            string connectionId,
            string wsUrl)
        {
            this.ConnectionId = connectionId ?? throw new global::System.ArgumentNullException(nameof(connectionId));
            this.WsUrl = wsUrl ?? throw new global::System.ArgumentNullException(nameof(wsUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsRegisterResponse" /> class.
        /// </summary>
        public EnvironmentsRegisterResponse()
        {
        }
    }
}