//HintName: G.Models.SchemaExtension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemaExtension
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public string Schema { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Required { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaExtension" /> class.
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="required"></param>
        public SchemaExtension(
            string schema,
            bool required)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaExtension" /> class.
        /// </summary>
        public SchemaExtension()
        {
        }
    }
}