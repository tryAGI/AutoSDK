//HintName: G.Models.ReposSetUserAccessRestrictionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposSetUserAccessRestrictionsRequest
    {
        /// <summary>
        /// The username for users
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposSetUserAccessRestrictionsRequest" /> class.
        /// </summary>
        /// <param name="users">
        /// The username for users
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposSetUserAccessRestrictionsRequest(
            global::System.Collections.Generic.IList<string> users)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposSetUserAccessRestrictionsRequest" /> class.
        /// </summary>
        public ReposSetUserAccessRestrictionsRequest()
        {
        }
    }
}