//HintName: G.Models.OverloadedError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OverloadedError
    {
        /// <summary>
        /// Default Value: overloaded_error
        /// </summary>
        /// <default>global::G.OverloadedErrorType.OverloadedError</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OverloadedErrorType Type { get; set; } = global::G.OverloadedErrorType.OverloadedError;

        /// <summary>
        /// Default Value: Overloaded
        /// </summary>
        /// <default>"Overloaded"</default>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OverloadedError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: overloaded_error
        /// </param>
        /// <param name="message">
        /// Default Value: Overloaded
        /// </param>
        public OverloadedError(
            string message,
            global::G.OverloadedErrorType type = global::G.OverloadedErrorType.OverloadedError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OverloadedError" /> class.
        /// </summary>
        public OverloadedError()
        {
        }
    }
}