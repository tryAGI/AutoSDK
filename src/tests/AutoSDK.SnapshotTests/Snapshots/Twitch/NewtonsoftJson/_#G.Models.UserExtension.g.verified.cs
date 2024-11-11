//HintName: G.Models.UserExtension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserExtension
    {
        /// <summary>
        /// An ID that identifies the extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The extension's version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// The extension's name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the extension is configured and can be activated. Is **true** if the extension is configured and can be activated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_activate", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CanActivate { get; set; } = default!;

        /// <summary>
        /// The extension types that you can activate for this extension. Possible values are:  <br/>
        ///   <br/>
        /// * component<br/>
        /// * mobile<br/>
        /// * overlay<br/>
        /// * panel
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UserExtensionTypeItem> Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExtension" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies the extension.
        /// </param>
        /// <param name="version">
        /// The extension's version.
        /// </param>
        /// <param name="name">
        /// The extension's name.
        /// </param>
        /// <param name="canActivate">
        /// A Boolean value that determines whether the extension is configured and can be activated. Is **true** if the extension is configured and can be activated.
        /// </param>
        /// <param name="type">
        /// The extension types that you can activate for this extension. Possible values are:  <br/>
        ///   <br/>
        /// * component<br/>
        /// * mobile<br/>
        /// * overlay<br/>
        /// * panel
        /// </param>
        public UserExtension(
            string id,
            string version,
            string name,
            bool canActivate,
            global::System.Collections.Generic.IList<global::G.UserExtensionTypeItem> type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CanActivate = canActivate;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExtension" /> class.
        /// </summary>
        public UserExtension()
        {
        }
    }
}