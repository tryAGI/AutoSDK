//HintName: G.Models.PromptRenderResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptRenderResponse
    {
        /// <summary>
        /// Indicates if the render was successful
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.CreateChatCompletionRequest, global::G.CreateCompletionRequest> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptRenderResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates if the render was successful
        /// </param>
        /// <param name="data"></param>
        public PromptRenderResponse(
            bool success,
            global::G.OneOf<global::G.CreateChatCompletionRequest, global::G.CreateCompletionRequest> data)
        {
            this.Success = success;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptRenderResponse" /> class.
        /// </summary>
        public PromptRenderResponse()
        {
        }
    }
}