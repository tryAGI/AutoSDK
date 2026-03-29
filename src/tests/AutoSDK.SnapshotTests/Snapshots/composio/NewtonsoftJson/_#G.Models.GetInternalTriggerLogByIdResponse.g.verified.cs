//HintName: G.Models.GetInternalTriggerLogByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalTriggerLogByIdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetInternalTriggerLogByIdResponseLog Log { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalTriggerLogByIdResponse" /> class.
        /// </summary>
        /// <param name="log"></param>
        public GetInternalTriggerLogByIdResponse(
            global::G.GetInternalTriggerLogByIdResponseLog log)
        {
            this.Log = log ?? throw new global::System.ArgumentNullException(nameof(log));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalTriggerLogByIdResponse" /> class.
        /// </summary>
        public GetInternalTriggerLogByIdResponse()
        {
        }
    }
}