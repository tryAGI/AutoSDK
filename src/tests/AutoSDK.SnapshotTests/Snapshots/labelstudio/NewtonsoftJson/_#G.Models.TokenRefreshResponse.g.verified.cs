//HintName: G.Models.TokenRefreshResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenRefreshResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access", Required = global::Newtonsoft.Json.Required.Always)]
        public string Access { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRefreshResponse" /> class.
        /// </summary>
        /// <param name="access"></param>
        public TokenRefreshResponse(
            string access)
        {
            this.Access = access ?? throw new global::System.ArgumentNullException(nameof(access));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRefreshResponse" /> class.
        /// </summary>
        public TokenRefreshResponse()
        {
        }
    }
}