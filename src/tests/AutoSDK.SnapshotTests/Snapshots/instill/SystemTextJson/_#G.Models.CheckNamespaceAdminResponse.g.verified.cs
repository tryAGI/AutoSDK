//HintName: G.Models.CheckNamespaceAdminResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        /// Namespace type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.CheckNamespaceAdminResponseNamespace?>? Type { get; set; }

        /// <summary>
        /// Namespace UID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.User9>? User { get; set; }

        /// <summary>
        /// Organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverterFactory1))]
        public global::G.AllOf<global::G.Organization7>? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}