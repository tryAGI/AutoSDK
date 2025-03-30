//HintName: G.Models.ArrayJsonSchemaPropertyInput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArrayJsonSchemaPropertyInput
    {
        /// <summary>
        /// Default Value: array
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ArrayJsonSchemaPropertyInputType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyInput, global::G.ArrayJsonSchemaPropertyInput> Items { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayJsonSchemaPropertyInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: array
        /// </param>
        /// <param name="items"></param>
        /// <param name="description"></param>
        public ArrayJsonSchemaPropertyInput(
            global::G.OneOf<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyInput, global::G.ArrayJsonSchemaPropertyInput> items,
            global::G.ArrayJsonSchemaPropertyInputType? type,
            string? description)
        {
            this.Items = items;
            this.Type = type;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayJsonSchemaPropertyInput" /> class.
        /// </summary>
        public ArrayJsonSchemaPropertyInput()
        {
        }
    }
}