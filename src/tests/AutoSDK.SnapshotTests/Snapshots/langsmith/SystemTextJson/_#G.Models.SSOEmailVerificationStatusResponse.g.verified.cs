//HintName: G.Models.SSOEmailVerificationStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSOEmailVerificationStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_confirmed_at")]
        public global::System.DateTime? EmailConfirmedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOEmailVerificationStatusResponse" /> class.
        /// </summary>
        /// <param name="emailConfirmedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SSOEmailVerificationStatusResponse(
            global::System.DateTime? emailConfirmedAt)
        {
            this.EmailConfirmedAt = emailConfirmedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOEmailVerificationStatusResponse" /> class.
        /// </summary>
        public SSOEmailVerificationStatusResponse()
        {
        }
    }
}