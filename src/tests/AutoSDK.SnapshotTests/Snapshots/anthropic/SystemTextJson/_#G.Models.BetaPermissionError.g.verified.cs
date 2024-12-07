//HintName: G.Models.BetaPermissionError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaPermissionError
    {
        /// <summary>
        /// Default Value: permission_error
        /// </summary>
        /// <default>global::G.BetaPermissionErrorType.PermissionError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaPermissionErrorTypeJsonConverter))]
        public global::G.BetaPermissionErrorType Type { get; set; } = global::G.BetaPermissionErrorType.PermissionError;

        /// <summary>
        /// Default Value: Permission denied
        /// </summary>
        /// <default>"Permission denied"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Permission denied";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPermissionError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: permission_error
        /// </param>
        /// <param name="message">
        /// Default Value: Permission denied
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaPermissionError(
            string message,
            global::G.BetaPermissionErrorType type = global::G.BetaPermissionErrorType.PermissionError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPermissionError" /> class.
        /// </summary>
        public BetaPermissionError()
        {
        }
    }
}