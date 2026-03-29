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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docs")]
        public string? Docs { get; set; }

        /// <summary>
        /// Provides Python type hint for data format that should guide external clients on how to produce / consume serialised data of specific kind.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serialised_data_type")]
        public string? SerialisedDataType { get; set; }

        /// <summary>
        /// Provides type hint regarding internal data representation that specific kind translates into when Workflow is run by Execution Engine. Relevant for blocks developers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("internal_data_type")]
        public string? InternalDataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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