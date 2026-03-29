//HintName: G.Models.DynamicOutputDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DynamicOutputDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"DynamicOutputDefinition"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "DynamicOutputDefinition";

        /// <summary>
        /// List representing union of kinds for defined output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public global::System.Collections.Generic.IList<string>? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicOutputDefinition" /> class.
        /// </summary>
        /// <param name="kind">
        /// List representing union of kinds for defined output
        /// </param>
        /// <param name="type"></param>
        public DynamicOutputDefinition(
            global::System.Collections.Generic.IList<string>? kind,
            string type = "DynamicOutputDefinition")
        {
            this.Type = type;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicOutputDefinition" /> class.
        /// </summary>
        public DynamicOutputDefinition()
        {
        }
    }
}