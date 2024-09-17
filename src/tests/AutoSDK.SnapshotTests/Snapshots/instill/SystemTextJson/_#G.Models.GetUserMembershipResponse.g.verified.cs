//HintName: G.Models.GetUserMembershipResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// GetUserMembershipResponse contains the user membership.
    /// </summary>
    public sealed partial class GetUserMembershipResponse
    {
        /// <summary>
        /// The requested user membership.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.UserMembership>? Membership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}