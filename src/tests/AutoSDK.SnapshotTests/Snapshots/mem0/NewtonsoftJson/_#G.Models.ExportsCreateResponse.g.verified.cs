//HintName: G.Models.ExportsCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportsCreateResponse
    {
        /// <summary>
        /// Example: Memory export request received. The export will be ready in a few seconds.
        /// </summary>
        /// <example>Memory export request received. The export will be ready in a few seconds.</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Memory export request received. The export will be ready in a few seconds.
        /// </param>
        /// <param name="id">
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        public ExportsCreateResponse(
            string message,
            global::System.Guid id)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsCreateResponse" /> class.
        /// </summary>
        public ExportsCreateResponse()
        {
        }
    }
}