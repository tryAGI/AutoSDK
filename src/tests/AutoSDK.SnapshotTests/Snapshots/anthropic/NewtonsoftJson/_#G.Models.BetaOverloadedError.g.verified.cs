//HintName: G.Models.BetaOverloadedError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaOverloadedError
    {
        /// <summary>
        /// Default Value: overloaded_error
        /// </summary>
        /// <default>global::G.BetaOverloadedErrorType.OverloadedError</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaOverloadedErrorType Type { get; set; } = global::G.BetaOverloadedErrorType.OverloadedError;

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
        /// Initializes a new instance of the <see cref="BetaOverloadedError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: overloaded_error
        /// </param>
        /// <param name="message">
        /// Default Value: Overloaded
        /// </param>
        public BetaOverloadedError(
            string message,
            global::G.BetaOverloadedErrorType type = global::G.BetaOverloadedErrorType.OverloadedError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOverloadedError" /> class.
        /// </summary>
        public BetaOverloadedError()
        {
        }
    }
}