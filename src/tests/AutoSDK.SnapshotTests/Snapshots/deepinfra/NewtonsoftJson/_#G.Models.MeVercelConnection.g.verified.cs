//HintName: G.Models.MeVercelConnection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeVercelConnection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string InstallationId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeVercelConnection" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="teamId"></param>
        /// <param name="installationId"></param>
        public MeVercelConnection(
            string userId,
            string installationId,
            string? teamId)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.InstallationId = installationId ?? throw new global::System.ArgumentNullException(nameof(installationId));
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeVercelConnection" /> class.
        /// </summary>
        public MeVercelConnection()
        {
        }
    }
}