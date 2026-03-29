//HintName: G.Models.Team.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Team
    {
        /// <summary>
        /// Identifier of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teamID", Required = global::Newtonsoft.Json.Required.Always)]
        public string TeamID { get; set; } = default!;

        /// <summary>
        /// Name of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// API key for the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// Whether the team is the default team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isDefault", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDefault { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        /// <param name="teamID">
        /// Identifier of the team
        /// </param>
        /// <param name="name">
        /// Name of the team
        /// </param>
        /// <param name="apiKey">
        /// API key for the team
        /// </param>
        /// <param name="isDefault">
        /// Whether the team is the default team
        /// </param>
        public Team(
            string teamID,
            string name,
            string apiKey,
            bool isDefault)
        {
            this.TeamID = teamID ?? throw new global::System.ArgumentNullException(nameof(teamID));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        public Team()
        {
        }
    }
}