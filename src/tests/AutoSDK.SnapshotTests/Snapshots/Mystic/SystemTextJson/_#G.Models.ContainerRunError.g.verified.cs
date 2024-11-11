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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ContainerRunErrorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ContainerRunErrorType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceback")]
        public string? Traceback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRunError" /> class.
        /// </summary>
        /// <param name="type">
        /// An enumeration.
        /// </param>
        /// <param name="message"></param>
        /// <param name="traceback"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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