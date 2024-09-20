//HintName: G.Models.PatchAuthenticatedUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAuthenticatedUserResponse
    {
        /// <summary>
        /// AuthenticatedUser contains the information of an authenticated user, i.e.,<br/>
        /// the public user information plus some fields that should only be accessed by<br/>
        /// the user themselves.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.AuthenticatedUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}