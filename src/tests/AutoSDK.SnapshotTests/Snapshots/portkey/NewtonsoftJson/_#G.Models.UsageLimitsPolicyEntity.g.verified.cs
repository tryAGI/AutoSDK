//HintName: G.Models.UsageLimitsPolicyEntity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageLimitsPolicyEntity
    {
        /// <summary>
        /// Entity ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The value key identifying the entity (e.g. metadata._user:username)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value_key")]
        public string? ValueKey { get; set; }

        /// <summary>
        /// Current usage value for this entity
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_usage")]
        public double? CurrentUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitsPolicyEntity" /> class.
        /// </summary>
        /// <param name="id">
        /// Entity ID
        /// </param>
        /// <param name="valueKey">
        /// The value key identifying the entity (e.g. metadata._user:username)
        /// </param>
        /// <param name="currentUsage">
        /// Current usage value for this entity
        /// </param>
        public UsageLimitsPolicyEntity(
            string? id,
            string? valueKey,
            double? currentUsage)
        {
            this.Id = id;
            this.ValueKey = valueKey;
            this.CurrentUsage = currentUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitsPolicyEntity" /> class.
        /// </summary>
        public UsageLimitsPolicyEntity()
        {
        }
    }
}