//HintName: G.Models.JwtResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JwtResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aud")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Aud { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JwtResponse" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="aud"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JwtResponse(
            string accessToken,
            object aud)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.Aud = aud ?? throw new global::System.ArgumentNullException(nameof(aud));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JwtResponse" /> class.
        /// </summary>
        public JwtResponse()
        {
        }
    }
}