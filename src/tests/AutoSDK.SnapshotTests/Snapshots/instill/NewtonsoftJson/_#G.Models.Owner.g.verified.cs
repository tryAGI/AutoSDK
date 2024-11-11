//HintName: G.Models.Owner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Owner is a wrapper for User and Organization, used to embed owner information in other resources.
    /// </summary>
    public sealed partial class Owner
    {
        /// <summary>
        /// User.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.User? User { get; set; }

        /// <summary>
        /// Organization.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Owner" /> class.
        /// </summary>
        /// <param name="user">
        /// User.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="organization">
        /// Organization.<br/>
        /// Included only in responses
        /// </param>
        public Owner(
            global::G.User? user,
            global::G.Organization? organization)
        {
            this.User = user;
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Owner" /> class.
        /// </summary>
        public Owner()
        {
        }
    }
}