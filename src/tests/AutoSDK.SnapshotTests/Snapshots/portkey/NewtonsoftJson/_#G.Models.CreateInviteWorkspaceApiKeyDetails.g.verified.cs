//HintName: G.Models.CreateInviteWorkspaceApiKeyDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInviteWorkspaceApiKeyDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scopes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Scopes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInviteWorkspaceApiKeyDetails" /> class.
        /// </summary>
        /// <param name="scopes"></param>
        public CreateInviteWorkspaceApiKeyDetails(
            global::System.Collections.Generic.IList<string> scopes)
        {
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInviteWorkspaceApiKeyDetails" /> class.
        /// </summary>
        public CreateInviteWorkspaceApiKeyDetails()
        {
        }
    }
}