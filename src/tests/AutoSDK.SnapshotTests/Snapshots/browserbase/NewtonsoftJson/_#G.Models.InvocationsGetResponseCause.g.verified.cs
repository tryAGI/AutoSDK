//HintName: G.Models.InvocationsGetResponseCause.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvocationsGetResponseCause
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InvocationsGetResponseCauseCodeJsonConverter))]
        public global::G.InvocationsGetResponseCauseCode Code { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="InvocationsGetResponseCause" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        public InvocationsGetResponseCause(
            global::G.InvocationsGetResponseCauseCode code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvocationsGetResponseCause" /> class.
        /// </summary>
        public InvocationsGetResponseCause()
        {
        }
    }
}