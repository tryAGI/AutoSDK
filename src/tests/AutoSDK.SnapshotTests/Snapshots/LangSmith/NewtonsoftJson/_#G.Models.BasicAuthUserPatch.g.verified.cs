//HintName: G.Models.BasicAuthUserPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BasicAuthUserPatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAuthUserPatch" /> class.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        public BasicAuthUserPatch(
            string? password,
            string? fullName)
        {
            this.Password = password;
            this.FullName = fullName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAuthUserPatch" /> class.
        /// </summary>
        public BasicAuthUserPatch()
        {
        }
    }
}