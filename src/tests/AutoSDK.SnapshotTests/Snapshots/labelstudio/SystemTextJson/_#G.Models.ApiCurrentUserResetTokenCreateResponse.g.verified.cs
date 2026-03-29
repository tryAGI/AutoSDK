//HintName: G.Models.ApiCurrentUserResetTokenCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiCurrentUserResetTokenCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiCurrentUserResetTokenCreateResponse" /> class.
        /// </summary>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiCurrentUserResetTokenCreateResponse(
            string? token)
        {
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiCurrentUserResetTokenCreateResponse" /> class.
        /// </summary>
        public ApiCurrentUserResetTokenCreateResponse()
        {
        }
    }
}