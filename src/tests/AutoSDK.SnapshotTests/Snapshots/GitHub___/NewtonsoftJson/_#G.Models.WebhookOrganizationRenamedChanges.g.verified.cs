//HintName: G.Models.WebhookOrganizationRenamedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookOrganizationRenamedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login")]
        public global::G.WebhookOrganizationRenamedChangesLogin? Login { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookOrganizationRenamedChanges" /> class.
        /// </summary>
        /// <param name="login"></param>
        public WebhookOrganizationRenamedChanges(
            global::G.WebhookOrganizationRenamedChangesLogin? login)
        {
            this.Login = login;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookOrganizationRenamedChanges" /> class.
        /// </summary>
        public WebhookOrganizationRenamedChanges()
        {
        }
    }
}