//HintName: G.Models.ComputerToolCallSafetyCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A pending safety check for the computer call.
    /// </summary>
    public sealed partial class ComputerToolCallSafetyCheck
    {
        /// <summary>
        /// The type of the pending safety check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The ID of the pending safety check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Details about the pending safety check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCallSafetyCheck" /> class.
        /// </summary>
        /// <param name="code">
        /// The type of the pending safety check.
        /// </param>
        /// <param name="id">
        /// The ID of the pending safety check.
        /// </param>
        /// <param name="message">
        /// Details about the pending safety check.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerToolCallSafetyCheck(
            string code,
            string id,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCallSafetyCheck" /> class.
        /// </summary>
        public ComputerToolCallSafetyCheck()
        {
        }
    }
}