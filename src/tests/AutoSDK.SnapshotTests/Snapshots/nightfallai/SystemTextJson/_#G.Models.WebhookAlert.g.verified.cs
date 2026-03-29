//HintName: G.Models.WebhookAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookAlert
    {
        /// <summary>
        /// Webhook URL (must accept HTTP POST)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAlert" /> class.
        /// </summary>
        /// <param name="address">
        /// Webhook URL (must accept HTTP POST)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookAlert(
            string? address)
        {
            this.Address = address;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookAlert" /> class.
        /// </summary>
        public WebhookAlert()
        {
        }
    }
}