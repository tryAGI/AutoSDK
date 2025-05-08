//HintName: G.Models.CreateEvalJsonlRunDataSource.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A JsonlRunDataSource object with that specifies a JSONL file that matches the eval 
    /// </summary>
    public sealed partial class CreateEvalJsonlRunDataSource
    {
        /// <summary>
        /// The type of data source. Always `jsonl`.<br/>
        /// Default Value: jsonl
        /// </summary>
        /// <default>global::G.CreateEvalJsonlRunDataSourceType.Jsonl</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateEvalJsonlRunDataSourceType Type { get; set; } = global::G.CreateEvalJsonlRunDataSourceType.Jsonl;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.EvalJsonlFileContentSource, global::G.EvalJsonlFileIdSource> Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalJsonlRunDataSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of data source. Always `jsonl`.<br/>
        /// Default Value: jsonl
        /// </param>
        /// <param name="source"></param>
        public CreateEvalJsonlRunDataSource(
            global::G.OneOf<global::G.EvalJsonlFileContentSource, global::G.EvalJsonlFileIdSource> source,
            global::G.CreateEvalJsonlRunDataSourceType type = global::G.CreateEvalJsonlRunDataSourceType.Jsonl)
        {
            this.Source = source;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalJsonlRunDataSource" /> class.
        /// </summary>
        public CreateEvalJsonlRunDataSource()
        {
        }
    }
}