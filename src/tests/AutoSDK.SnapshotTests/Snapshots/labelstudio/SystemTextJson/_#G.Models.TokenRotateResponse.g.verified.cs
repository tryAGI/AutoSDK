//HintName: G.Models.TokenRotateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenRotateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Refresh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRotateResponse" /> class.
        /// </summary>
        /// <param name="refresh"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenRotateResponse(
            string refresh)
        {
            this.Refresh = refresh ?? throw new global::System.ArgumentNullException(nameof(refresh));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRotateResponse" /> class.
        /// </summary>
        public TokenRotateResponse()
        {
        }
    }
}