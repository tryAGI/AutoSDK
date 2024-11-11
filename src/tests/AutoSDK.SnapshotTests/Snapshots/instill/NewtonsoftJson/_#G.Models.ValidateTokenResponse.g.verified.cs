//HintName: G.Models.ValidateTokenResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ValidateTokenResponse contains the validation of a token.
    /// </summary>
    public sealed partial class ValidateTokenResponse
    {
        /// <summary>
        /// If token is valid, UUID of the user that owns it.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userUid")]
        public string? UserUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateTokenResponse" /> class.
        /// </summary>
        /// <param name="userUid">
        /// If token is valid, UUID of the user that owns it.<br/>
        /// Included only in responses
        /// </param>
        public ValidateTokenResponse(
            string? userUid)
        {
            this.UserUid = userUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateTokenResponse" /> class.
        /// </summary>
        public ValidateTokenResponse()
        {
        }
    }
}