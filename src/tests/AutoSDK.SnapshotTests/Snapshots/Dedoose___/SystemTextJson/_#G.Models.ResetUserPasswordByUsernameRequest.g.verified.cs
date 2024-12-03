//HintName: G.Models.ResetUserPasswordByUsernameRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResetUserPasswordByUsernameRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetUserPasswordByUsernameRequest" /> class.
        /// </summary>
        /// <param name="username"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ResetUserPasswordByUsernameRequest(
            string username)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetUserPasswordByUsernameRequest" /> class.
        /// </summary>
        public ResetUserPasswordByUsernameRequest()
        {
        }
    }
}