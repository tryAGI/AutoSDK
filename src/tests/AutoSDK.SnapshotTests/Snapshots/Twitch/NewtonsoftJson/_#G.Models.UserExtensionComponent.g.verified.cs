//HintName: G.Models.UserExtensionComponent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserExtensionComponent
    {
        /// <summary>
        /// A Boolean value that determines the extension’s activation state. If **false**, the user has not configured a component extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Active { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The extension’s version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The extension’s name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The x-coordinate where the extension is placed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x")]
        public int? X { get; set; }

        /// <summary>
        /// The y-coordinate where the extension is placed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y")]
        public int? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExtensionComponent" /> class.
        /// </summary>
        /// <param name="active">
        /// A Boolean value that determines the extension’s activation state. If **false**, the user has not configured a component extension.
        /// </param>
        /// <param name="id">
        /// An ID that identifies the extension.
        /// </param>
        /// <param name="version">
        /// The extension’s version.
        /// </param>
        /// <param name="name">
        /// The extension’s name.
        /// </param>
        /// <param name="x">
        /// The x-coordinate where the extension is placed.
        /// </param>
        /// <param name="y">
        /// The y-coordinate where the extension is placed.
        /// </param>
        public UserExtensionComponent(
            bool active,
            string? id,
            string? version,
            string? name,
            int? x,
            int? y)
        {
            this.Active = active;
            this.Id = id;
            this.Version = version;
            this.Name = name;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExtensionComponent" /> class.
        /// </summary>
        public UserExtensionComponent()
        {
        }
    }
}