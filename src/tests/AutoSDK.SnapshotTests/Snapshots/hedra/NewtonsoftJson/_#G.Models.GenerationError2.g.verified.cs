//HintName: G.Models.GenerationError2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationError2
    {
        /// <summary>
        /// The class of error encountered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ErrorCodeJsonConverter))]
        public global::G.ErrorCode Type { get; set; } = default!;

        /// <summary>
        /// The error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationError2" /> class.
        /// </summary>
        /// <param name="type">
        /// The class of error encountered.
        /// </param>
        /// <param name="message">
        /// The error message.
        /// </param>
        public GenerationError2(
            global::G.ErrorCode type,
            string message)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationError2" /> class.
        /// </summary>
        public GenerationError2()
        {
        }
    }
}