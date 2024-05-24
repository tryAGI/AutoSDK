//HintName: G.Models.WebhookInstallationRepositoriesAddedRepositoriesRemoved.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookInstallationRepositoriesAddedRepositoriesRemoved
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// Unique identifier of the repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// Whether the repository is private or public.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private")]
        public bool Private { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}