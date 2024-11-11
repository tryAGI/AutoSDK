//HintName: G.Models.SSOConfirmEmailRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSOConfirmEmailRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOConfirmEmailRequest" /> class.
        /// </summary>
        /// <param name="token"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SSOConfirmEmailRequest(
            string token)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOConfirmEmailRequest" /> class.
        /// </summary>
        public SSOConfirmEmailRequest()
        {
        }
    }
}