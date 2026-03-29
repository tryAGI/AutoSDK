//HintName: G.Models.LSEAPITokenList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LSEAPITokenList
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public string ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LSEAPITokenList" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="expiresAt">
        /// Included only in responses
        /// </param>
        /// <param name="token">
        /// Included only in responses
        /// </param>
        public LSEAPITokenList(
            string createdAt = default!,
            string expiresAt = default!,
            string token = default!)
        {
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LSEAPITokenList" /> class.
        /// </summary>
        public LSEAPITokenList()
        {
        }
    }
}