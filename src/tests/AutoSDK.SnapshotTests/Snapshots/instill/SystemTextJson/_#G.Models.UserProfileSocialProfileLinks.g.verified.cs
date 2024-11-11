//HintName: G.Models.UserProfileSocialProfileLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Social profile links list the links to the user's social profiles.<br/>
    /// The key represents the provider, and the value is the corresponding URL.
    /// </summary>
    public sealed partial class UserProfileSocialProfileLinks
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileSocialProfileLinks" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UserProfileSocialProfileLinks(
 )
        {
        }
    }
}