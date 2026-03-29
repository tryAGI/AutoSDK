//HintName: G.Models.FunctionsInvokeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionsInvokeRequest
    {
        /// <summary>
        /// JSON object that can be stored in a JSONB column
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params")]
        public object? Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionCreateParams")]
        public global::G.FunctionsInvokeRequestSessionCreateParams? SessionCreateParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequest" /> class.
        /// </summary>
        /// <param name="params">
        /// JSON object that can be stored in a JSONB column
        /// </param>
        /// <param name="sessionCreateParams"></param>
        public FunctionsInvokeRequest(
            object? @params,
            global::G.FunctionsInvokeRequestSessionCreateParams? sessionCreateParams)
        {
            this.Params = @params;
            this.SessionCreateParams = sessionCreateParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequest" /> class.
        /// </summary>
        public FunctionsInvokeRequest()
        {
        }
    }
}