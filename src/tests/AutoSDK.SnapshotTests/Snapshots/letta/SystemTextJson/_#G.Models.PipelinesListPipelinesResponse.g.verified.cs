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
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PipelinesListPipelinesResponsePipeline> Pipelines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasNextPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelinesResponse" /> class.
        /// </summary>
        /// <param name="pipelines"></param>
        /// <param name="hasNextPage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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