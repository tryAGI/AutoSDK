//HintName: G.Models.AdminApiKeysDeleteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminApiKeysDeleteResponse
    {
        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Example: key_abc
        /// </summary>
        /// <example>key_abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: organization.admin_api_key.deleted
        /// </summary>
        /// <example>organization.admin_api_key.deleted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeysDeleteResponse" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Example: true
        /// </param>
        /// <param name="id">
        /// Example: key_abc
        /// </param>
        /// <param name="object">
        /// Example: organization.admin_api_key.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminApiKeysDeleteResponse(
            bool? deleted,
            string? id,
            string? @object)
        {
            this.Deleted = deleted;
            this.Id = id;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeysDeleteResponse" /> class.
        /// </summary>
        public AdminApiKeysDeleteResponse()
        {
        }
    }
}