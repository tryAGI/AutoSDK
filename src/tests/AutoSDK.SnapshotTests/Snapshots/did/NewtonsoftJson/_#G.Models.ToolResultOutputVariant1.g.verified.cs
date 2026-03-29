//HintName: G.Models.ToolResultOutputVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolResultOutputVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ToolResultOutputVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultOutputVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        public ToolResultOutputVariant1(
            string value,
            global::G.ToolResultOutputVariant1Type type)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResultOutputVariant1" /> class.
        /// </summary>
        public ToolResultOutputVariant1()
        {
        }
    }
}