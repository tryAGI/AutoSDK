//HintName: G.Models.FunctionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result output from a `FunctionCall` that contains a string representing the `FunctionDeclaration.name` and a structured JSON object containing any output from the function is used as context to the model. This should contain the result of a`FunctionCall` made based on model prediction.
    /// </summary>
    public sealed partial class FunctionResponse
    {
        /// <summary>
        /// Optional. The identifier of the function call this response is for. Populated by the client to match the corresponding function call `id`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Required. The name of the function to call. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 128.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Required. The function response in JSON object format. Callers can use any keys of their choice that fit the function's syntax to return the function output, e.g. "output", "result", etc. In particular, if the function call failed to execute, the response can have an "error" key to return error details to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public object? Response { get; set; }

        /// <summary>
        /// Optional. Ordered `Parts` that constitute a function response. Parts may have different IANA MIME types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parts")]
        public global::System.Collections.Generic.IList<global::G.FunctionResponsePart>? Parts { get; set; }

        /// <summary>
        /// Optional. Signals that function call continues, and more responses will be returned, turning the function call into a generator. Is only applicable to NON_BLOCKING function calls, is ignored otherwise. If set to false, future responses will not be considered. It is allowed to return empty `response` with `will_continue=False` to signal that the function call is finished. This may still trigger the model generation. To avoid triggering the generation and finish the function call, additionally set `scheduling` to `SILENT`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("willContinue")]
        public bool? WillContinue { get; set; }

        /// <summary>
        /// Optional. Specifies how the response should be scheduled in the conversation. Only applicable to NON_BLOCKING function calls, is ignored otherwise. Defaults to WHEN_IDLE.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scheduling")]
        public global::G.FunctionResponseScheduling? Scheduling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Optional. The identifier of the function call this response is for. Populated by the client to match the corresponding function call `id`.
        /// </param>
        /// <param name="name">
        /// Required. The name of the function to call. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 128.
        /// </param>
        /// <param name="response">
        /// Required. The function response in JSON object format. Callers can use any keys of their choice that fit the function's syntax to return the function output, e.g. "output", "result", etc. In particular, if the function call failed to execute, the response can have an "error" key to return error details to the model.
        /// </param>
        /// <param name="parts">
        /// Optional. Ordered `Parts` that constitute a function response. Parts may have different IANA MIME types.
        /// </param>
        /// <param name="willContinue">
        /// Optional. Signals that function call continues, and more responses will be returned, turning the function call into a generator. Is only applicable to NON_BLOCKING function calls, is ignored otherwise. If set to false, future responses will not be considered. It is allowed to return empty `response` with `will_continue=False` to signal that the function call is finished. This may still trigger the model generation. To avoid triggering the generation and finish the function call, additionally set `scheduling` to `SILENT`.
        /// </param>
        /// <param name="scheduling">
        /// Optional. Specifies how the response should be scheduled in the conversation. Only applicable to NON_BLOCKING function calls, is ignored otherwise. Defaults to WHEN_IDLE.
        /// </param>
        public FunctionResponse(
            string? id,
            string? name,
            object? response,
            global::System.Collections.Generic.IList<global::G.FunctionResponsePart>? parts,
            bool? willContinue,
            global::G.FunctionResponseScheduling? scheduling)
        {
            this.Id = id;
            this.Name = name;
            this.Response = response;
            this.Parts = parts;
            this.WillContinue = willContinue;
            this.Scheduling = scheduling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResponse" /> class.
        /// </summary>
        public FunctionResponse()
        {
        }
    }
}