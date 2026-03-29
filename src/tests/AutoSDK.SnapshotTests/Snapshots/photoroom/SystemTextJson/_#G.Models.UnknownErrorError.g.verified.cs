//HintName: G.Models.UnknownErrorError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnknownErrorError
    {
        /// <summary>
        /// The message describing the error<br/>
        /// Example: An unexpected error occurred. Please try again later or contact support.
        /// </summary>
        /// <example>An unexpected error occurred. Please try again later or contact support.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnknownErrorError" /> class.
        /// </summary>
        /// <param name="message">
        /// The message describing the error<br/>
        /// Example: An unexpected error occurred. Please try again later or contact support.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnknownErrorError(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnknownErrorError" /> class.
        /// </summary>
        public UnknownErrorError()
        {
        }
    }
}