//HintName: G.Models.DependentAvailableToolIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependentAvailableToolIdentifier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Default Value: available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DependentAvailableToolIdentifierType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtUnixSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependentAvailableToolIdentifierAccessLevel AccessLevel { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentAvailableToolIdentifier" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: available
        /// </param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="accessLevel"></param>
        public DependentAvailableToolIdentifier(
            string id,
            string name,
            int createdAtUnixSecs,
            global::G.DependentAvailableToolIdentifierAccessLevel accessLevel,
            global::G.DependentAvailableToolIdentifierType? type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.AccessLevel = accessLevel;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentAvailableToolIdentifier" /> class.
        /// </summary>
        public DependentAvailableToolIdentifier()
        {
        }
    }
}