//HintName: G.Models.CreateWebhookResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebhookResponse3
    {
        /// <summary>
        /// Example: You don't have access to this project
        /// </summary>
        /// <example>You don't have access to this project</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookResponse3" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: You don't have access to this project
        /// </param>
        public CreateWebhookResponse3(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookResponse3" /> class.
        /// </summary>
        public CreateWebhookResponse3()
        {
        }
    }
}