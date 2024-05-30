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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The extension's version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// The extension's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the extension is configured and can be activated. Is **true** if the extension is configured and can be activated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_activate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanActivate { get; set; }

        /// <summary>
        /// The extension types that you can activate for this extension. Possible values are:  
        ///   
        /// * component
        /// * mobile
        /// * overlay
        /// * panel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<UserExtensionType> Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}