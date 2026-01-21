//HintName: G.Models.ComputerCallSafetyCheckParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A pending safety check for the computer call.
    /// </summary>
    public sealed partial class ComputerCallSafetyCheckParam
    {
        /// <summary>
        /// The ID of the pending safety check.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerCallSafetyCheckParam" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the pending safety check.
        /// </param>
        /// <param name="code"></param>
        /// <param name="message"></param>
        public ComputerCallSafetyCheckParam(
            string id,
            string? code,
            string? message)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerCallSafetyCheckParam" /> class.
        /// </summary>
        public ComputerCallSafetyCheckParam()
        {
        }
    }
}