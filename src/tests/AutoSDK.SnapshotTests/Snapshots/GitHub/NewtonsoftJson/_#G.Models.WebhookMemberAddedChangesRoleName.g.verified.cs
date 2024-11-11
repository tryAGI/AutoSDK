//HintName: G.Models.WebhookMemberAddedChangesRoleName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role assigned to the collaborator.
    /// </summary>
    public sealed partial class WebhookMemberAddedChangesRoleName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to", Required = global::Newtonsoft.Json.Required.Always)]
        public string To { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMemberAddedChangesRoleName" /> class.
        /// </summary>
        /// <param name="to"></param>
        public WebhookMemberAddedChangesRoleName(
            string to)
        {
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMemberAddedChangesRoleName" /> class.
        /// </summary>
        public WebhookMemberAddedChangesRoleName()
        {
        }
    }
}