//HintName: G.Models.Kind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Kind
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
        [global::System.Text.Json.Serialization.JsonPropertyName("docs")]
        public string? Docs { get; set; }

        /// <summary>
        /// Provides Python type hint for data format that should guide external clients on how to produce / consume serialised data of specific kind.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serialised_data_type")]
        public string? SerialisedDataType { get; set; }

        /// <summary>
        /// Provides type hint regarding internal data representation that specific kind translates into when Workflow is run by Execution Engine. Relevant for blocks developers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_data_type")]
        public string? InternalDataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Kind" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="docs"></param>
        /// <param name="serialisedDataType">
        /// Provides Python type hint for data format that should guide external clients on how to produce / consume serialised data of specific kind.
        /// </param>
        /// <param name="internalDataType">
        /// Provides type hint regarding internal data representation that specific kind translates into when Workflow is run by Execution Engine. Relevant for blocks developers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Kind(
            string name,
            string? description,
            string? docs,
            string? serialisedDataType,
            string? internalDataType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Docs = docs;
            this.SerialisedDataType = serialisedDataType;
            this.InternalDataType = internalDataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Kind" /> class.
        /// </summary>
        public Kind()
        {
        }
    }
}