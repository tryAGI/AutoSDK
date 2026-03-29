//HintName: G.Models.DatasetItemUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset item update request
    /// </summary>
    public sealed partial class DatasetItemUpdate
    {
        /// <summary>
        /// Dataset item input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// Dataset item expected output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_output")]
        public string? ExpectedOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.JsonNode? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::G.JsonNode? Data { get; set; }

        /// <summary>
        /// Dataset item description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Tags to add
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_to_add")]
        public global::System.Collections.Generic.IList<string>? TagsToAdd { get; set; }

        /// <summary>
        /// Tags to remove
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_to_remove")]
        public global::System.Collections.Generic.IList<string>? TagsToRemove { get; set; }

        /// <summary>
        /// Evaluators
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        public global::System.Collections.Generic.IList<global::G.EvaluatorItem>? Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_policy")]
        public global::G.ExecutionPolicy? ExecutionPolicy { get; set; }

        /// <summary>
        /// When true, clears the item-level execution policy (falls back to dataset-level)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_execution_policy")]
        public bool? ClearExecutionPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemUpdate" /> class.
        /// </summary>
        /// <param name="input">
        /// Dataset item input
        /// </param>
        /// <param name="expectedOutput">
        /// Dataset item expected output
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="data"></param>
        /// <param name="description">
        /// Dataset item description
        /// </param>
        /// <param name="tags">
        /// Tags
        /// </param>
        /// <param name="tagsToAdd">
        /// Tags to add
        /// </param>
        /// <param name="tagsToRemove">
        /// Tags to remove
        /// </param>
        /// <param name="evaluators">
        /// Evaluators
        /// </param>
        /// <param name="executionPolicy"></param>
        /// <param name="clearExecutionPolicy">
        /// When true, clears the item-level execution policy (falls back to dataset-level)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetItemUpdate(
            string? input,
            string? expectedOutput,
            global::G.JsonNode? metadata,
            global::G.JsonNode? data,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? tagsToAdd,
            global::System.Collections.Generic.IList<string>? tagsToRemove,
            global::System.Collections.Generic.IList<global::G.EvaluatorItem>? evaluators,
            global::G.ExecutionPolicy? executionPolicy,
            bool? clearExecutionPolicy)
        {
            this.Input = input;
            this.ExpectedOutput = expectedOutput;
            this.Metadata = metadata;
            this.Data = data;
            this.Description = description;
            this.Tags = tags;
            this.TagsToAdd = tagsToAdd;
            this.TagsToRemove = tagsToRemove;
            this.Evaluators = evaluators;
            this.ExecutionPolicy = executionPolicy;
            this.ClearExecutionPolicy = clearExecutionPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemUpdate" /> class.
        /// </summary>
        public DatasetItemUpdate()
        {
        }
    }
}