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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PermissionErrorType Type { get; set; } = global::G.PermissionErrorType.PermissionError;

        /// <summary>
        /// Default Value: Permission denied
        /// </summary>
        /// <default>"Permission denied"</default>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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