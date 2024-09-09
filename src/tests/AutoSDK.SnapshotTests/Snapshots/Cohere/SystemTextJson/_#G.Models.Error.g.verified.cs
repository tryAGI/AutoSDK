//HintName: G.Models.Error.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error is the response for any unsuccessful event.
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// A developer-facing error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}