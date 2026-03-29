//HintName: G.Models.OrganizationId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A serializer mixin that takes an additional `fields` argument that controls<br/>
    /// which fields should be displayed.
    /// </summary>
    public sealed partial class OrganizationId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_info")]
        public string? ContactInfo { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationId" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="contactInfo"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationId(
            string title,
            string? contactInfo,
            global::System.DateTime createdAt = default!,
            int id = default!)
        {
            this.ContactInfo = contactInfo;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationId" /> class.
        /// </summary>
        public OrganizationId()
        {
        }
    }
}