//HintName: G.Models.UnauthorizedResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Unauthorized - Authentication required or invalid credentials
    /// </summary>
    public sealed partial class UnauthorizedResponse
    {
        /// <summary>
        /// Error data for UnauthorizedResponse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UnauthorizedResponseErrorData Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorizedResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for UnauthorizedResponse
        /// </param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnauthorizedResponse(
            global::G.UnauthorizedResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorizedResponse" /> class.
        /// </summary>
        public UnauthorizedResponse()
        {
        }
    }
}