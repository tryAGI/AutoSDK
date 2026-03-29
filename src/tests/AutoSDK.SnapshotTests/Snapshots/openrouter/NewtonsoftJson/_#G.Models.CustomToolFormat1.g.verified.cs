//HintName: G.Models.CustomToolFormat1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomToolFormat1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CustomToolFormatOneOf1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("definition", Required = global::Newtonsoft.Json.Required.Always)]
        public string Definition { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("syntax", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomToolFormatOneOf1Syntax Syntax { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolFormat1" /> class.
        /// </summary>
        /// <param name="definition"></param>
        /// <param name="syntax"></param>
        /// <param name="type"></param>
        public CustomToolFormat1(
            string definition,
            global::G.CustomToolFormatOneOf1Syntax syntax,
            global::G.CustomToolFormatOneOf1Type type)
        {
            this.Type = type;
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.Syntax = syntax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolFormat1" /> class.
        /// </summary>
        public CustomToolFormat1()
        {
        }
    }
}