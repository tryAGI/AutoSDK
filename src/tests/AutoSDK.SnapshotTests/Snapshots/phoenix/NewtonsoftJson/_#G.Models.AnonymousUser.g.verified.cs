//HintName: G.Models.AnonymousUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnonymousUser
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"ANONYMOUS"</default>
        [global::Newtonsoft.Json.JsonProperty("auth_method")]
        public string AuthMethod { get; set; } = "ANONYMOUS";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymousUser" /> class.
        /// </summary>
        /// <param name="authMethod"></param>
        public AnonymousUser(
            string authMethod = "ANONYMOUS")
        {
            this.AuthMethod = authMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymousUser" /> class.
        /// </summary>
        public AnonymousUser()
        {
        }
    }
}