﻿//HintName: G.Models.NotFoundError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotFoundError
    {
        /// <summary>
        /// Default Value: not_found_error
        /// </summary>
        /// <default>global::G.NotFoundErrorType.NotFoundError</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.NotFoundErrorType Type { get; set; } = global::G.NotFoundErrorType.NotFoundError;

        /// <summary>
        /// Default Value: Not found
        /// </summary>
        /// <default>"Not found"</default>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: not_found_error
        /// </param>
        /// <param name="message">
        /// Default Value: Not found
        /// </param>
        public NotFoundError(
            string message,
            global::G.NotFoundErrorType type = global::G.NotFoundErrorType.NotFoundError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundError" /> class.
        /// </summary>
        public NotFoundError()
        {
        }
    }
}