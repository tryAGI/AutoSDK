//HintName: G.Models.CheckNamespaceAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CheckNamespaceAdminResponse contains the availability of a namespace or the type<br/>
    /// of resource that's using it.
    /// </summary>
    public sealed partial class CheckNamespaceAdminResponse
    {
        /// <summary>
        /// Organizations group several users. As entities, they can own resources such<br/>
        /// as pipelines or releases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// Namespace UID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// User describes an individual that interacts with Instill AI. It doesn't<br/>
        /// contain any private information about the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.User? User { get; set; }

        /// <summary>
        /// Namespace contains information about the availability of a namespace.<br/>
        ///  - NAMESPACE_AVAILABLE: Available.<br/>
        ///  - NAMESPACE_USER: Namespace belongs to a user.<br/>
        ///  - NAMESPACE_ORGANIZATION: Namespace belongs to an organization.<br/>
        ///  - NAMESPACE_RESERVED: Reserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CheckNamespaceAdminResponseNamespaceJsonConverter))]
        public global::G.CheckNamespaceAdminResponseNamespace? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}