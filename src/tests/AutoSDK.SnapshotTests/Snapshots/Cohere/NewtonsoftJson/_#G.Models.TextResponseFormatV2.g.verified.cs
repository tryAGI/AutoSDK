//HintName: G.Models.TextResponseFormatV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextResponseFormatV2
    {
        /// <summary>
        /// Defaults to `"text"`.<br/>
        /// When set to `"json_object"`, the model's output will be a valid JSON Object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseFormatTypeV2 Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormatV2" /> class.
        /// </summary>
        /// <param name="type">
        /// Defaults to `"text"`.<br/>
        /// When set to `"json_object"`, the model's output will be a valid JSON Object.
        /// </param>
        public TextResponseFormatV2(
            global::G.ResponseFormatTypeV2 type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormatV2" /> class.
        /// </summary>
        public TextResponseFormatV2()
        {
        }
    }
}