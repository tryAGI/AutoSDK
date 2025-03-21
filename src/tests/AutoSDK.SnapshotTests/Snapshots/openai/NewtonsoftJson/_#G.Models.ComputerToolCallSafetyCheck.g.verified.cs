//HintName: G.Models.ComputerToolCallSafetyCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A pending safety check for the computer call.
    /// </summary>
    public sealed partial class ComputerToolCallSafetyCheck
    {
        /// <summary>
        /// The ID of the pending safety check.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of the pending safety check.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Details about the pending safety check.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCallSafetyCheck" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the pending safety check.
        /// </param>
        /// <param name="code">
        /// The type of the pending safety check.
        /// </param>
        /// <param name="message">
        /// Details about the pending safety check.
        /// </param>
        public ComputerToolCallSafetyCheck(
            string id,
            string code,
            string message)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolCallSafetyCheck" /> class.
        /// </summary>
        public ComputerToolCallSafetyCheck()
        {
        }
    }
}