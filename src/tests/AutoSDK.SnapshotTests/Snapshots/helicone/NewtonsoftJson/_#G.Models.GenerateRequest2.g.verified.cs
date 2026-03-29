//HintName: G.Models.GenerateRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logRequest")]
        public bool? LogRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("useAIGateway")]
        public bool? UseAIGateway { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRequest2" /> class.
        /// </summary>
        /// <param name="logRequest"></param>
        /// <param name="useAIGateway"></param>
        public GenerateRequest2(
            bool? logRequest,
            bool? useAIGateway)
        {
            this.LogRequest = logRequest;
            this.UseAIGateway = useAIGateway;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRequest2" /> class.
        /// </summary>
        public GenerateRequest2()
        {
        }
    }
}