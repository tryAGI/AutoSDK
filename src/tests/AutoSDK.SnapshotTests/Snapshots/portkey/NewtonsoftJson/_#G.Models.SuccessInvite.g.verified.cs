//HintName: G.Models.SuccessInvite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"id":"a286286b-633d-4c4f-bddb-86b84a50a25c","invite_link":"https://app.portkey.ai/invite_id"}
    /// </summary>
    public sealed partial class SuccessInvite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invite_link", Required = global::Newtonsoft.Json.Required.Always)]
        public string InviteLink { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessInvite" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inviteLink"></param>
        public SuccessInvite(
            string id,
            string inviteLink)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InviteLink = inviteLink ?? throw new global::System.ArgumentNullException(nameof(inviteLink));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessInvite" /> class.
        /// </summary>
        public SuccessInvite()
        {
        }
    }
}