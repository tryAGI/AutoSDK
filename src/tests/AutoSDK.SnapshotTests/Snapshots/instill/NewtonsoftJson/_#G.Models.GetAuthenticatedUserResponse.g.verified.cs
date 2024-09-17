//HintName: G.Models.GetAuthenticatedUserResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// GetAuthenticatedUserResponse contains the requested authenticated user.
    /// </summary>
    public sealed partial class GetAuthenticatedUserResponse
    {
        /// <summary>
        /// The authenticated user resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.AllOf<global::G.AuthenticatedUser>? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}