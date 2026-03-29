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
        [global::System.Text.Json.Serialization.JsonPropertyName("teamID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamID { get; set; }

        /// <summary>
        /// Name of the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// API key for the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Whether the team is the default team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefault")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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