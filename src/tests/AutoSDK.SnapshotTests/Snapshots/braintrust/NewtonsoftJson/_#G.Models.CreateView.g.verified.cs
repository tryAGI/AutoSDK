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
        [global::Newtonsoft.Json.JsonProperty("object_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AclObjectType ObjectType { get; set; } = default!;

        /// <summary>
        /// The id of the object the view applies to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ObjectId { get; set; } = default!;

        /// <summary>
        /// Type of object that the view corresponds to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("view_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateViewViewType ViewType { get; set; } = default!;

        /// <summary>
        /// Name of the view
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The view definition
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("view_data")]
        public global::G.ViewData? ViewData { get; set; }

        /// <summary>
        /// Options for the view in the app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.ViewOptions? Options { get; set; }

        /// <summary>
        /// Identifies the user who created the view
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Date of role deletion, or null if the role is still active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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