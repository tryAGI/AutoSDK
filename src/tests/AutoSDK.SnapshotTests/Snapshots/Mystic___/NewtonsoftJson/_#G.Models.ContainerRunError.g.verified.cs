//HintName: G.Models.ContainerRunError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class ContainerRunError
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ContainerRunErrorType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceback")]
        public string? Traceback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRunError" /> class.
        /// </summary>
        /// <param name="type">
        /// An enumeration.
        /// </param>
        /// <param name="message"></param>
        /// <param name="traceback"></param>
        public ContainerRunError(
            global::G.ContainerRunErrorType type,
            string message,
            string? traceback)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Traceback = traceback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRunError" /> class.
        /// </summary>
        public ContainerRunError()
        {
        }
    }
}