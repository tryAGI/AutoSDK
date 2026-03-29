//HintName: G.Models.BaseInputsOneOf1Items2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseInputsOneOf1Items2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseInputsOneOf1ItemsOneOf2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseInputsOneOf1ItemsOneOf2Output Output { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ToolCallStatusEnum? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInputsOneOf1Items2" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="output"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        public BaseInputsOneOf1Items2(
            string callId,
            global::G.BaseInputsOneOf1ItemsOneOf2Output output,
            global::G.BaseInputsOneOf1ItemsOneOf2Type type,
            string? id,
            global::G.ToolCallStatusEnum? status)
        {
            this.Type = type;
            this.Id = id;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Output = output;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInputsOneOf1Items2" /> class.
        /// </summary>
        public BaseInputsOneOf1Items2()
        {
        }
    }
}