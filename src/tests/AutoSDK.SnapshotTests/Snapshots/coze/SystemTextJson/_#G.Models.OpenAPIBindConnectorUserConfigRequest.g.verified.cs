//HintName: G.Models.OpenAPIBindConnectorUserConfigRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIBindConnectorUserConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UserConfig> Configs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIBindConnectorUserConfigRequest" /> class.
        /// </summary>
        /// <param name="configs"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIBindConnectorUserConfigRequest(
            global::System.Collections.Generic.IList<global::G.UserConfig> configs,
            string? userId)
        {
            this.Configs = configs ?? throw new global::System.ArgumentNullException(nameof(configs));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIBindConnectorUserConfigRequest" /> class.
        /// </summary>
        public OpenAPIBindConnectorUserConfigRequest()
        {
        }
    }
}