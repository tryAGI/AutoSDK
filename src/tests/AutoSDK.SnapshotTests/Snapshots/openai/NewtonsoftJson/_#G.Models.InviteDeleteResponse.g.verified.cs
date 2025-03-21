//HintName: G.Models.InviteDeleteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteDeleteResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `organization.invite.deleted`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.InviteDeleteResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteDeleteResponse" /> class.
        /// </summary>
        /// <param name="deleted"></param>
        /// <param name="id"></param>
        /// <param name="object">
        /// The object type, which is always `organization.invite.deleted`
        /// </param>
        public InviteDeleteResponse(
            bool deleted,
            string id,
            global::G.InviteDeleteResponseObject @object)
        {
            this.Deleted = deleted;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteDeleteResponse" /> class.
        /// </summary>
        public InviteDeleteResponse()
        {
        }
    }
}