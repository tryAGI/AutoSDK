//HintName: G.Models.APIKeyCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIKeyCreate
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("prefix")]
        public string Prefix { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// The API key itself. Will be generated on creation but not returned in future requests.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("secret")]
        public string Secret { get; set; } = default!;

        /// <summary>
        /// If the API key is revoked, clients cannot use it anymore. (This cannot be undone.)<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("revoked")]
        public bool Revoked { get; set; } = default!;

        /// <summary>
        /// A free-form name for the API key. Need not be unique. 50 characters max.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Once API key expires, clients cannot use it anymore.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiryDate")]
        public global::System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyCreate" /> class.
        /// </summary>
        /// <param name="prefix">
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="creator">
        /// Included only in responses
        /// </param>
        /// <param name="secret">
        /// The API key itself. Will be generated on creation but not returned in future requests.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="revoked">
        /// If the API key is revoked, clients cannot use it anymore. (This cannot be undone.)<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// A free-form name for the API key. Need not be unique. 50 characters max.
        /// </param>
        /// <param name="expiryDate">
        /// Once API key expires, clients cannot use it anymore.
        /// </param>
        public APIKeyCreate(
            string name,
            string? creator,
            global::System.DateTime? expiryDate,
            string prefix = default!,
            global::System.DateTime created = default!,
            string secret = default!,
            bool revoked = default!)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Prefix = prefix;
            this.Created = created;
            this.Creator = creator;
            this.Secret = secret;
            this.Revoked = revoked;
            this.ExpiryDate = expiryDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyCreate" /> class.
        /// </summary>
        public APIKeyCreate()
        {
        }
    }
}