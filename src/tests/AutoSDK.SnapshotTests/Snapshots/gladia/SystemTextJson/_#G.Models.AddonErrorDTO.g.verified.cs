//HintName: G.Models.AddonErrorDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddonErrorDTO
    {
        /// <summary>
        /// Status code of the addon error<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Reason of the addon error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exception")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Exception { get; set; }

        /// <summary>
        /// Detailed message of the addon error
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
        /// Initializes a new instance of the <see cref="AddonErrorDTO" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// Status code of the addon error<br/>
        /// Example: 500
        /// </param>
        /// <param name="exception">
        /// Reason of the addon error
        /// </param>
        /// <param name="message">
        /// Detailed message of the addon error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddonErrorDTO(
            int statusCode,
            string exception,
            string message)
        {
            this.StatusCode = statusCode;
            this.Exception = exception ?? throw new global::System.ArgumentNullException(nameof(exception));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddonErrorDTO" /> class.
        /// </summary>
        public AddonErrorDTO()
        {
        }
    }
}