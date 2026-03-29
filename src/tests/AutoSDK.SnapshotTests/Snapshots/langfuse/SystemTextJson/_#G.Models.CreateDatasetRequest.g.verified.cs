//HintName: G.Models.CreateDatasetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// JSON Schema for validating dataset item inputs. When set, all new and existing dataset items will be validated against this schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSchema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// JSON Schema for validating dataset item expected outputs. When set, all new and existing dataset items will be validated against this schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectedOutputSchema")]
        public object? ExpectedOutputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="metadata"></param>
        /// <param name="inputSchema">
        /// JSON Schema for validating dataset item inputs. When set, all new and existing dataset items will be validated against this schema.
        /// </param>
        /// <param name="expectedOutputSchema">
        /// JSON Schema for validating dataset item expected outputs. When set, all new and existing dataset items will be validated against this schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetRequest(
            string name,
            string? description,
            object? metadata,
            object? inputSchema,
            object? expectedOutputSchema)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Metadata = metadata;
            this.InputSchema = inputSchema;
            this.ExpectedOutputSchema = expectedOutputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetRequest" /> class.
        /// </summary>
        public CreateDatasetRequest()
        {
        }
    }
}