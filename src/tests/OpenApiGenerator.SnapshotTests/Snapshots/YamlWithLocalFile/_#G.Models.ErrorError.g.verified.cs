//HintName: G.Models.ErrorError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorError
    {
        /// <summary>
        /// <br/>Example: Wrong ip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public required string Title { get; set; }

        /// <summary>
        /// <br/>Example: Please provide a valid IP address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public required string Message { get; set; }

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}