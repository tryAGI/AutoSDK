//HintName: G.Models.BetaInputSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaInputSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaInputSchemaType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputSchema" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="properties"></param>
        public BetaInputSchema(
            global::G.BetaInputSchemaType type,
            object? properties)
        {
            this.Type = type;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputSchema" /> class.
        /// </summary>
        public BetaInputSchema()
        {
        }
    }
}