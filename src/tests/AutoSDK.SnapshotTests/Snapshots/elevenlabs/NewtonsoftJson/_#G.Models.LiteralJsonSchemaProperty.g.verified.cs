//HintName: G.Models.LiteralJsonSchemaProperty.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"constant_value":"Constant value","description":"My property","dynamic_variable":"Dynamic variable"}
    /// </summary>
    public sealed partial class LiteralJsonSchemaProperty
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LiteralJsonSchemaPropertyType Type { get; set; } = default!;

        /// <summary>
        /// The description of the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The dynamic variable of the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_variable")]
        public string? DynamicVariable { get; set; }

        /// <summary>
        /// The constant value of the property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("constant_value")]
        public global::G.AnyOf<string, int?, double?, bool?>? ConstantValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteralJsonSchemaProperty" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="description">
        /// The description of the property
        /// </param>
        /// <param name="dynamicVariable">
        /// The dynamic variable of the property
        /// </param>
        /// <param name="constantValue">
        /// The constant value of the property
        /// </param>
        public LiteralJsonSchemaProperty(
            global::G.LiteralJsonSchemaPropertyType type,
            string? description,
            string? dynamicVariable,
            global::G.AnyOf<string, int?, double?, bool?>? constantValue)
        {
            this.Type = type;
            this.Description = description;
            this.DynamicVariable = dynamicVariable;
            this.ConstantValue = constantValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteralJsonSchemaProperty" /> class.
        /// </summary>
        public LiteralJsonSchemaProperty()
        {
        }
    }
}