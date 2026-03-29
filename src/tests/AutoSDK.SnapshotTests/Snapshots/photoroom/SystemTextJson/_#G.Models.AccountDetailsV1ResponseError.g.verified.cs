//HintName: G.Models.AccountDetailsV1ResponseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountDetailsV1ResponseError
    {
        /// <summary>
        /// The message describing the error<br/>
        /// Example: apiKey: Required
        /// </summary>
        /// <example>apiKey: Required</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV1ResponseError" /> class.
        /// </summary>
        /// <param name="message">
        /// The message describing the error<br/>
        /// Example: apiKey: Required
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountDetailsV1ResponseError(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV1ResponseError" /> class.
        /// </summary>
        public AccountDetailsV1ResponseError()
        {
        }
    }
}