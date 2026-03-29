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
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh")]
        public string? Refresh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRefreshRequest" /> class.
        /// </summary>
        /// <param name="refresh">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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