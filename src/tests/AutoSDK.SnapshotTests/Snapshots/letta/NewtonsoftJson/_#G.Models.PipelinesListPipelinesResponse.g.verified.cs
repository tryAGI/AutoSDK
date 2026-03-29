//HintName: G.Models.PipelinesListPipelinesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesListPipelinesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelines", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PipelinesListPipelinesResponsePipeline> Pipelines { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hasNextPage", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasNextPage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelinesResponse" /> class.
        /// </summary>
        /// <param name="pipelines"></param>
        /// <param name="hasNextPage"></param>
        public PipelinesListPipelinesResponse(
            global::System.Collections.Generic.IList<global::G.PipelinesListPipelinesResponsePipeline> pipelines,
            bool hasNextPage)
        {
            this.Pipelines = pipelines ?? throw new global::System.ArgumentNullException(nameof(pipelines));
            this.HasNextPage = hasNextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelinesResponse" /> class.
        /// </summary>
        public PipelinesListPipelinesResponse()
        {
        }
    }
}