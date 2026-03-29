//HintName: G.Models.OnlineEvaluatorByEvaluatorId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OnlineEvaluatorByEvaluatorId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public object Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineEvaluatorByEvaluatorId" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        public OnlineEvaluatorByEvaluatorId(
            object config,
            string id)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineEvaluatorByEvaluatorId" /> class.
        /// </summary>
        public OnlineEvaluatorByEvaluatorId()
        {
        }
    }
}