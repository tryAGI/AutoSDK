﻿//HintName: G.Models.CheckNamespaceByUIDAdminResponse.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CheckNamespaceByUIDAdminResponseNamespaceJsonConverter))]
        public global::G.CheckNamespaceByUIDAdminResponseNamespace? Type { get; set; }

        /// <summary>
        /// Namespace ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        /// Initializes a new instance of the <see cref="CheckNamespaceByUIDAdminResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Namespace type.
        /// </param>
        /// <param name="id">
        /// Namespace ID.
        /// </param>
        /// <param name="user">
        /// User.
        /// </param>
        /// <param name="organization">
        /// Organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckNamespaceByUIDAdminResponse(
            global::G.CheckNamespaceByUIDAdminResponseNamespace? type,
            string? id,
            global::G.User? user,
            global::G.Organization? organization)
        {
            this.Type = type;
            this.Id = id;
            this.User = user;
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckNamespaceByUIDAdminResponse" /> class.
        /// </summary>
        public CheckNamespaceByUIDAdminResponse()
        {
        }
    }
}