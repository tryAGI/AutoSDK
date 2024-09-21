//HintName: G.Models.GetUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetUserResponse contains the requested user.
    /// </summary>
    public sealed partial class GetUserResponse
    {
        /// <summary>
        /// The user resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.User? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}