//HintName: G.Models.DatasetUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Update class for Dataset.
    /// </summary>
    public sealed partial class DatasetUpdate
    {
        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.Missing>))]
        public global::G.AnyOf<string, global::G.Missing>? Name { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.Missing>))]
        public global::G.AnyOf<string, global::G.Missing>? Description { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_schema_definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::G.Missing>))]
        public global::G.AnyOf<object, global::G.Missing>? InputsSchemaDefinition { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs_schema_definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<object, global::G.Missing>))]
        public global::G.AnyOf<object, global::G.Missing>? OutputsSchemaDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_examples")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ExampleUpdate>? PatchExamples { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.DatasetTransformation>, global::G.Missing>))]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.DatasetTransformation>, global::G.Missing>? Transformations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUpdate" /> class.
        /// </summary>
        /// <param name="name">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="description">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="inputsSchemaDefinition">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="outputsSchemaDefinition">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="patchExamples"></param>
        /// <param name="transformations">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetUpdate(
            global::G.AnyOf<string, global::G.Missing>? name,
            global::G.AnyOf<string, global::G.Missing>? description,
            global::G.AnyOf<object, global::G.Missing>? inputsSchemaDefinition,
            global::G.AnyOf<object, global::G.Missing>? outputsSchemaDefinition,
            global::System.Collections.Generic.Dictionary<string, global::G.ExampleUpdate>? patchExamples,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.DatasetTransformation>, global::G.Missing>? transformations)
        {
            this.Name = name;
            this.Description = description;
            this.InputsSchemaDefinition = inputsSchemaDefinition;
            this.OutputsSchemaDefinition = outputsSchemaDefinition;
            this.PatchExamples = patchExamples;
            this.Transformations = transformations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUpdate" /> class.
        /// </summary>
        public DatasetUpdate()
        {
        }

    }
}