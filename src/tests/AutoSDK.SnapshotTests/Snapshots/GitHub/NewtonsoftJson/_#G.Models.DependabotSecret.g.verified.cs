//HintName: G.Models.DependabotSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set secrets for Dependabot.
    /// </summary>
    public sealed partial class DependabotSecret
    {
        /// <summary>
        /// The name of the secret.<br/>
        /// Example: MY_ARTIFACTORY_PASSWORD
        /// </summary>
        /// <example>MY_ARTIFACTORY_PASSWORD</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotSecret" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the secret.<br/>
        /// Example: MY_ARTIFACTORY_PASSWORD
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public DependabotSecret(
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotSecret" /> class.
        /// </summary>
        public DependabotSecret()
        {
        }
    }
}