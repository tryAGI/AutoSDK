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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaPermissionErrorType Type { get; set; } = global::G.BetaPermissionErrorType.PermissionError;

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
        /// Initializes a new instance of the <see cref="BetaPermissionError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: permission_error
        /// </param>
        /// <param name="message">
        /// Default Value: Permission denied
        /// </param>
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