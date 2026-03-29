//HintName: G.Models.LLMResponseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMResponseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataDetailsResponse")]
        public global::G.LLMResponseBodyDataDetailsResponse? DataDetailsResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vectorDBDetailsResponse")]
        public global::G.LLMResponseBodyVectorDBDetailsResponse? VectorDBDetailsResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolDetailsResponse")]
        public global::G.LLMResponseBodyToolDetailsResponse? ToolDetailsResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.LLMResponseBodyError? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responses")]
        public global::System.Collections.Generic.IList<global::G.Response>? Responses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.Message>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBody" /> class.
        /// </summary>
        /// <param name="dataDetailsResponse"></param>
        /// <param name="vectorDBDetailsResponse"></param>
        /// <param name="toolDetailsResponse"></param>
        /// <param name="error"></param>
        /// <param name="model"></param>
        /// <param name="instructions"></param>
        /// <param name="responses"></param>
        /// <param name="messages"></param>
        public LLMResponseBody(
            global::G.LLMResponseBodyDataDetailsResponse? dataDetailsResponse,
            global::G.LLMResponseBodyVectorDBDetailsResponse? vectorDBDetailsResponse,
            global::G.LLMResponseBodyToolDetailsResponse? toolDetailsResponse,
            global::G.LLMResponseBodyError? error,
            string? model,
            string? instructions,
            global::System.Collections.Generic.IList<global::G.Response>? responses,
            global::System.Collections.Generic.IList<global::G.Message>? messages)
        {
            this.DataDetailsResponse = dataDetailsResponse;
            this.VectorDBDetailsResponse = vectorDBDetailsResponse;
            this.ToolDetailsResponse = toolDetailsResponse;
            this.Error = error;
            this.Model = model;
            this.Instructions = instructions;
            this.Responses = responses;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBody" /> class.
        /// </summary>
        public LLMResponseBody()
        {
        }
    }
}