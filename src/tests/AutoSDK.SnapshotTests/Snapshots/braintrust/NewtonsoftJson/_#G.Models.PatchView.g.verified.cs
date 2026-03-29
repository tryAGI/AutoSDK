//HintName: G.Models.PatchView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchView
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
        [global::Newtonsoft.Json.JsonProperty("view_type")]
        public global::G.PatchViewViewType? ViewType { get; set; }

        /// <summary>
        /// Name of the view
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchView" /> class.
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
        public PatchView(
            global::G.AclObjectType objectType,
            global::System.Guid objectId,
            global::G.PatchViewViewType? viewType,
            string? name,
            global::G.ViewData? viewData,
            global::G.ViewOptions? options,
            global::System.Guid? userId)
        {
            this.ObjectType = objectType;
            this.ObjectId = objectId;
            this.ViewType = viewType;
            this.Name = name;
            this.ViewData = viewData;
            this.Options = options;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchView" /> class.
        /// </summary>
        public PatchView()
        {
        }
    }
}