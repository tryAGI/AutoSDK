//HintName: G.Models.AuthenticationScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthenticationScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("specUri", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpecUri { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("primary", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Primary { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationScheme" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="specUri"></param>
        /// <param name="type"></param>
        /// <param name="primary"></param>
        public AuthenticationScheme(
            string name,
            string description,
            string specUri,
            string type,
            bool primary)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.SpecUri = specUri ?? throw new global::System.ArgumentNullException(nameof(specUri));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Primary = primary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationScheme" /> class.
        /// </summary>
        public AuthenticationScheme()
        {
        }
    }
}