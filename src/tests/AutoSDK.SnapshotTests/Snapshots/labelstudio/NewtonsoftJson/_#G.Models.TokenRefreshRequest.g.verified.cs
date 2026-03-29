//HintName: G.Models.TokenRefreshRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenRefreshRequest
    {
        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refresh")]
        public string? Refresh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRefreshRequest" /> class.
        /// </summary>
        /// <param name="refresh">
        /// Included only in requests
        /// </param>
        public TokenRefreshRequest(
            string? refresh)
        {
            this.Refresh = refresh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRefreshRequest" /> class.
        /// </summary>
        public TokenRefreshRequest()
        {
        }
    }
}