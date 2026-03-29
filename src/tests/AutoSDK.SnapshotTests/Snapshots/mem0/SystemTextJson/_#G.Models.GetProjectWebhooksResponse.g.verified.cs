//HintName: G.Models.GetProjectWebhooksResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectWebhooksResponse
    {
        /// <summary>
        /// Example: You don't have access to this project
        /// </summary>
        /// <example>You don't have access to this project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectWebhooksResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: You don't have access to this project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectWebhooksResponse(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectWebhooksResponse" /> class.
        /// </summary>
        public GetProjectWebhooksResponse()
        {
        }
    }
}