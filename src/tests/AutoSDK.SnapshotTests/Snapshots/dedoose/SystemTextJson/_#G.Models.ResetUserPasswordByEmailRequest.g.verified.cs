//HintName: G.Models.ResetUserPasswordByEmailRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResetUserPasswordByEmailRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userEmail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetUserPasswordByEmailRequest" /> class.
        /// </summary>
        /// <param name="userEmail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResetUserPasswordByEmailRequest(
            string userEmail)
        {
            this.UserEmail = userEmail ?? throw new global::System.ArgumentNullException(nameof(userEmail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetUserPasswordByEmailRequest" /> class.
        /// </summary>
        public ResetUserPasswordByEmailRequest()
        {
        }
    }
}