//HintName: G.Models.CheckNamespaceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CheckNamespaceResponse contains the availability of a namespace or the type<br/>
    /// of resource that's using it.
    /// </summary>
    public sealed partial class CheckNamespaceResponse
    {
        /// <summary>
        /// Namespace contains information about the availability of a namespace.<br/>
        ///  - NAMESPACE_AVAILABLE: Available.<br/>
        ///  - NAMESPACE_USER: Namespace belongs to a user.<br/>
        ///  - NAMESPACE_ORGANIZATION: Namespace belongs to an organization.<br/>
        ///  - NAMESPACE_RESERVED: Reserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CheckNamespaceResponseNamespaceJsonConverter))]
        public global::G.CheckNamespaceResponseNamespace? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}