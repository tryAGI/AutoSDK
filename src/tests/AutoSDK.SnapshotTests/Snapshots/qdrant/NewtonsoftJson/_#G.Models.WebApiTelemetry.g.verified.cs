//HintName: G.Models.WebApiTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebApiTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responses", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.OperationDurationStatistics>> Responses { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("per_collection_responses")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.OperationDurationStatistics>>>? PerCollectionResponses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebApiTelemetry" /> class.
        /// </summary>
        /// <param name="responses"></param>
        /// <param name="perCollectionResponses"></param>
        public WebApiTelemetry(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.OperationDurationStatistics>> responses,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.OperationDurationStatistics>>>? perCollectionResponses)
        {
            this.Responses = responses ?? throw new global::System.ArgumentNullException(nameof(responses));
            this.PerCollectionResponses = perCollectionResponses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebApiTelemetry" /> class.
        /// </summary>
        public WebApiTelemetry()
        {
        }
    }
}