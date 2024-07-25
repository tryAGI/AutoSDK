//HintName: G.Models.DatasetPublicSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Public schema for datasets.<br/>
    /// Doesn't currently include session counts/stats<br/>
    /// since public test project sharing is not yet shipped
    /// </summary>
    public sealed partial class DatasetPublicSchema
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
        public global::System.AnyOf<string?, object?>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Default Value: kv
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_type")]
        public global::System.AnyOf<global::G.DataType?, object?>? DataType { get; set; } = global::G.DataType.Kv;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs_schema_definition")]
        public global::System.AnyOf<object?, object?>? InputsSchemaDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs_schema_definition")]
        public global::System.AnyOf<object?, object?>? OutputsSchemaDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("example_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExampleCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}