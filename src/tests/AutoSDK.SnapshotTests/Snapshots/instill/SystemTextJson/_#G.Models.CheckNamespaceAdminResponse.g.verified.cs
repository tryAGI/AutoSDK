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
        /// Namespace type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CheckNamespaceAdminResponseNamespaceJsonConverter))]
        public global::G.CheckNamespaceAdminResponseNamespace? Type { get; set; }

        /// <summary>
        /// Namespace UID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// User.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.User? User { get; set; }

        /// <summary>
        /// Organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckNamespaceAdminResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Namespace type.
        /// </param>
        /// <param name="uid">
        /// Namespace UID.
        /// </param>
        /// <param name="user">
        /// User.
        /// </param>
        /// <param name="organization">
        /// Organization.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CheckNamespaceAdminResponse(
            global::G.CheckNamespaceAdminResponseNamespace? type,
            string? uid,
            global::G.User? user,
            global::G.Organization? organization)
        {
            this.Type = type;
            this.Uid = uid;
            this.User = user;
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckNamespaceAdminResponse" /> class.
        /// </summary>
        public CheckNamespaceAdminResponse()
        {
        }
    }
}