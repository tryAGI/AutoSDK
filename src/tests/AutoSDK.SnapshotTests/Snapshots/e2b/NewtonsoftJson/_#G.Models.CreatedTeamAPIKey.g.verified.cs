//HintName: G.Models.CreatedTeamAPIKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatedTeamAPIKey
    {
        /// <summary>
        /// Identifier of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Raw value of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mask", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.IdentifierMaskingDetails Mask { get; set; } = default!;

        /// <summary>
        /// Name of the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Timestamp of API key creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdBy")]
        public global::G.TeamUser? CreatedBy { get; set; }

        /// <summary>
        /// Last time this API key was used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUsed")]
        public global::System.DateTime? LastUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedTeamAPIKey" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the API key
        /// </param>
        /// <param name="key">
        /// Raw value of the API key
        /// </param>
        /// <param name="mask"></param>
        /// <param name="name">
        /// Name of the API key
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of API key creation
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="lastUsed">
        /// Last time this API key was used
        /// </param>
        public CreatedTeamAPIKey(
            global::System.Guid id,
            string key,
            global::G.IdentifierMaskingDetails mask,
            string name,
            global::System.DateTime createdAt,
            global::G.TeamUser? createdBy,
            global::System.DateTime? lastUsed)
        {
            this.Id = id;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Mask = mask ?? throw new global::System.ArgumentNullException(nameof(mask));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUsed = lastUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedTeamAPIKey" /> class.
        /// </summary>
        public CreatedTeamAPIKey()
        {
        }
    }
}