//HintName: G.Models.PatchAISecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAISecret
    {
        /// <summary>
        /// Name of the AI secret
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAISecret" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the AI secret
        /// </param>
        /// <param name="type"></param>
        /// <param name="metadata"></param>
        /// <param name="secret"></param>
        public PatchAISecret(
            string? name,
            string? type,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata,
            string? secret)
        {
            this.Name = name;
            this.Type = type;
            this.Metadata = metadata;
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAISecret" /> class.
        /// </summary>
        public PatchAISecret()
        {
        }
    }
}