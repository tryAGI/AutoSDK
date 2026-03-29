//HintName: G.Models.ScimUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScimUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schemas", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Schemas { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userName", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScimName Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emails", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ScimEmail> Emails { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UserMeta Meta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimUser" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="id"></param>
        /// <param name="userName"></param>
        /// <param name="name"></param>
        /// <param name="emails"></param>
        /// <param name="meta"></param>
        public ScimUser(
            global::System.Collections.Generic.IList<string> schemas,
            string id,
            string userName,
            global::G.ScimName name,
            global::System.Collections.Generic.IList<global::G.ScimEmail> emails,
            global::G.UserMeta meta)
        {
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimUser" /> class.
        /// </summary>
        public ScimUser()
        {
        }
    }
}