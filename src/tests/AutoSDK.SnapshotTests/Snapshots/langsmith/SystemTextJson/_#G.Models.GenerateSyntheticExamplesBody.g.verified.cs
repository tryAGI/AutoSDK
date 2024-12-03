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
        [global::System.Text.Json.Serialization.JsonPropertyName("example_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExampleIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSyntheticExamplesBody" /> class.
        /// </summary>
        /// <param name="exampleIds"></param>
        /// <param name="numExamples"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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