//HintName: G.Models.LlmSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LLMRequestBody Request { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public global::G.LLMResponseBody? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmSchema" /> class.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="response"></param>
        public LlmSchema(
            global::G.LLMRequestBody request,
            global::G.LLMResponseBody? response)
        {
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmSchema" /> class.
        /// </summary>
        public LlmSchema()
        {
        }
    }
}