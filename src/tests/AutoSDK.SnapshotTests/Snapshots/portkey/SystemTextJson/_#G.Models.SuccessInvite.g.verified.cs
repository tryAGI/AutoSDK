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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InviteLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessInvite" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inviteLink"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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