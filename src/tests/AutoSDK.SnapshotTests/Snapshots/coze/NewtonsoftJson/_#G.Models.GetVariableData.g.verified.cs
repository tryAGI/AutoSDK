//HintName: G.Models.GetVariableData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVariableData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::System.Collections.Generic.IList<global::G.KVItem>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVariableData" /> class.
        /// </summary>
        /// <param name="items"></param>
        public GetVariableData(
            global::System.Collections.Generic.IList<global::G.KVItem>? items)
        {
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVariableData" /> class.
        /// </summary>
        public GetVariableData()
        {
        }
    }
}