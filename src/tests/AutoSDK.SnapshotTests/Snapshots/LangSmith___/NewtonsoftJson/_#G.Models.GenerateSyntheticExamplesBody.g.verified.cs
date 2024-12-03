//HintName: G.Models.GenerateSyntheticExamplesBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateSyntheticExamplesBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("example_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExampleIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_examples", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumExamples { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSyntheticExamplesBody" /> class.
        /// </summary>
        /// <param name="exampleIds"></param>
        /// <param name="numExamples"></param>
        public GenerateSyntheticExamplesBody(
            int numExamples,
            global::System.Collections.Generic.IList<global::System.Guid>? exampleIds)
        {
            this.NumExamples = numExamples;
            this.ExampleIds = exampleIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSyntheticExamplesBody" /> class.
        /// </summary>
        public GenerateSyntheticExamplesBody()
        {
        }
    }
}