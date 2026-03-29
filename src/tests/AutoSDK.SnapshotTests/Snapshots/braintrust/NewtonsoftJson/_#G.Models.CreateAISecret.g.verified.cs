//HintName: G.Models.CreateAISecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAISecret
    {
        /// <summary>
        /// Name of the AI secret
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// Secret value. If omitted in a PUT request, the existing secret value will be left intact, not replaced with null.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the AI Secret belongs in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_name")]
        public string? OrgName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAISecret" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the AI secret
        /// </param>
        /// <param name="type"></param>
        /// <param name="metadata"></param>
        /// <param name="secret">
        /// Secret value. If omitted in a PUT request, the existing secret value will be left intact, not replaced with null.
        /// </param>
        /// <param name="orgName">
        /// For nearly all users, this parameter should be unnecessary. But in the rare case that your API key belongs to multiple organizations, you may specify the name of the organization the AI Secret belongs in.
        /// </param>
        public CreateAISecret(
            string name,
            string? type,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata,
            string? secret,
            string? orgName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Metadata = metadata;
            this.Secret = secret;
            this.OrgName = orgName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAISecret" /> class.
        /// </summary>
        public CreateAISecret()
        {
        }
    }
}