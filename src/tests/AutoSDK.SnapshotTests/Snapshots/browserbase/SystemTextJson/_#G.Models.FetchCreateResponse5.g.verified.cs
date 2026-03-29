//HintName: G.Models.FetchCreateResponse5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FetchCreateResponse5
    {
        /// <summary>
        /// HTTP status code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// HTTP error name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Human-readable error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Unique identifier for the fetch request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchCreateResponse5" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// HTTP status code
        /// </param>
        /// <param name="error">
        /// HTTP error name
        /// </param>
        /// <param name="message">
        /// Human-readable error message
        /// </param>
        /// <param name="id">
        /// Unique identifier for the fetch request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FetchCreateResponse5(
            int statusCode,
            string error,
            string message,
            string id)
        {
            this.StatusCode = statusCode;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchCreateResponse5" /> class.
        /// </summary>
        public FetchCreateResponse5()
        {
        }
    }
}