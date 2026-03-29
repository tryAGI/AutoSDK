//HintName: G.Models.CreateSandboxesTimeoutRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxesTimeoutRequest
    {
        /// <summary>
        /// Timeout in seconds from the current time after which the sandbox should expire
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesTimeoutRequest" /> class.
        /// </summary>
        /// <param name="timeout">
        /// Timeout in seconds from the current time after which the sandbox should expire
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesTimeoutRequest(
            int timeout)
        {
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesTimeoutRequest" /> class.
        /// </summary>
        public CreateSandboxesTimeoutRequest()
        {
        }
    }
}