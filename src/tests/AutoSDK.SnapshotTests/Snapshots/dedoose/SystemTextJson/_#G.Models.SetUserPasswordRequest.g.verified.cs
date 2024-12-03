//HintName: G.Models.SetUserPasswordRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetUserPasswordRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rsaEncrptedPass")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RsaEncrptedPass { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetUserPasswordRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="rsaEncrptedPass"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SetUserPasswordRequest(
            global::System.Guid userId,
            string rsaEncrptedPass)
        {
            this.UserId = userId;
            this.RsaEncrptedPass = rsaEncrptedPass ?? throw new global::System.ArgumentNullException(nameof(rsaEncrptedPass));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetUserPasswordRequest" /> class.
        /// </summary>
        public SetUserPasswordRequest()
        {
        }
    }
}