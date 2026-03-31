//HintName: G.Models.CreateView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateView
    {
        /// <summary>
        /// The object type that the ACL applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AclObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AclObjectType ObjectType { get; set; }

        /// <summary>
        /// The id of the object the view applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ObjectId { get; set; }

        /// <summary>
        /// Type of object that the view corresponds to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateViewViewTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateViewViewType ViewType { get; set; }

        /// <summary>
        /// Name of the view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The view definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view_data")]
        public global::G.ViewData? ViewData { get; set; }

        /// <summary>
        /// Options for the view in the app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ViewOptionsJsonConverter))]
        public global::G.ViewOptions? Options { get; set; }

        /// <summary>
        /// Identifies the user who created the view
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Date of role deletion, or null if the role is still active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateView" /> class.
        /// </summary>
        /// <param name="objectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="objectId">
        /// The id of the object the view applies to
        /// </param>
        /// <param name="viewType">
        /// Type of object that the view corresponds to.
        /// </param>
        /// <param name="name">
        /// Name of the view
        /// </param>
        /// <param name="viewData">
        /// The view definition
        /// </param>
        /// <param name="options">
        /// Options for the view in the app
        /// </param>
        /// <param name="userId">
        /// Identifies the user who created the view
        /// </param>
        /// <param name="deletedAt">
        /// Date of role deletion, or null if the role is still active
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateView(
            global::G.AclObjectType objectType,
            global::System.Guid objectId,
            global::G.CreateViewViewType viewType,
            string name,
            global::G.ViewData? viewData,
            global::G.ViewOptions? options,
            global::System.Guid? userId,
            global::System.DateTime? deletedAt)
        {
            this.ObjectType = objectType;
            this.ObjectId = objectId;
            this.ViewType = viewType;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ViewData = viewData;
            this.Options = options;
            this.UserId = userId;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateView" /> class.
        /// </summary>
        public CreateView()
        {
        }
    }
}