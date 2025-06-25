//HintName: G.Models.PermissionError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PermissionError
    {
        /// <summary>
        /// Default Value: permission_error
        /// </summary>
        /// <default>global::G.PermissionErrorType.PermissionError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PermissionErrorTypeJsonConverter))]
        public global::G.PermissionErrorType Type { get; set; } = global::G.PermissionErrorType.PermissionError;

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
        /// Initializes a new instance of the <see cref="PermissionError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: permission_error
        /// </param>
        /// <param name="message">
        /// Default Value: Permission denied
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionError(
            string message,
            global::G.PermissionErrorType type = global::G.PermissionErrorType.PermissionError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionError" /> class.
        /// </summary>
        public PermissionError()
        {
        }
    }
}