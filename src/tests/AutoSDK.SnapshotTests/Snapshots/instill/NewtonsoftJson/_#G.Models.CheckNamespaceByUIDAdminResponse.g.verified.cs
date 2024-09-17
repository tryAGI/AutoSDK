//HintName: G.Models.CheckNamespaceByUIDAdminResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// CheckNamespaceByUIDAdminResponse contains the availability of a namespace or the type<br/>
    /// of resource that's using it.
    /// </summary>
    public sealed partial class CheckNamespaceByUIDAdminResponse
    {
        /// <summary>
        /// Namespace type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AllOf<global::G.CheckNamespaceByUIDAdminResponseNamespace?>? Type { get; set; }

        /// <summary>
        /// Namespace ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// User.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.AllOf<global::G.User9>? User { get; set; }

        /// <summary>
        /// Organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.AllOf<global::G.Organization7>? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}