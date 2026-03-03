//HintName: G.Models.SchemaDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemaDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.SchemaDefinition>? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::G.SchemaDefinition? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allOf")]
        public global::System.Collections.Generic.IList<global::G.SchemaDefinition>? AllOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("anyOf")]
        public global::System.Collections.Generic.IList<global::G.SchemaDefinition>? AnyOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oneOf")]
        public global::System.Collections.Generic.IList<global::G.SchemaDefinition>? OneOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("not")]
        public global::G.SchemaDefinition? Not { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("if")]
        public global::G.SchemaDefinition? If { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("then")]
        public global::G.SchemaDefinition? Then { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("else")]
        public global::G.SchemaDefinition? Else { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaDefinition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="properties"></param>
        /// <param name="items"></param>
        /// <param name="allOf"></param>
        /// <param name="anyOf"></param>
        /// <param name="oneOf"></param>
        /// <param name="not"></param>
        /// <param name="if"></param>
        /// <param name="then"></param>
        /// <param name="else"></param>
        public SchemaDefinition(
            string? type,
            string? description,
            global::System.Collections.Generic.Dictionary<string, global::G.SchemaDefinition>? properties,
            global::G.SchemaDefinition? items,
            global::System.Collections.Generic.IList<global::G.SchemaDefinition>? allOf,
            global::System.Collections.Generic.IList<global::G.SchemaDefinition>? anyOf,
            global::System.Collections.Generic.IList<global::G.SchemaDefinition>? oneOf,
            global::G.SchemaDefinition? not,
            global::G.SchemaDefinition? @if,
            global::G.SchemaDefinition? then,
            global::G.SchemaDefinition? @else)
        {
            this.Type = type;
            this.Description = description;
            this.Properties = properties;
            this.Items = items;
            this.AllOf = allOf;
            this.AnyOf = anyOf;
            this.OneOf = oneOf;
            this.Not = not;
            this.If = @if;
            this.Then = then;
            this.Else = @else;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaDefinition" /> class.
        /// </summary>
        public SchemaDefinition()
        {
        }
    }
}