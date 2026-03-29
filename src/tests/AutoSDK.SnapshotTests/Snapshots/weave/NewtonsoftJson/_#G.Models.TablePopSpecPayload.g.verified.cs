//HintName: G.Models.TablePopSpecPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TablePopSpecPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TablePopSpecPayload" /> class.
        /// </summary>
        /// <param name="index"></param>
        public TablePopSpecPayload(
            int index)
        {
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TablePopSpecPayload" /> class.
        /// </summary>
        public TablePopSpecPayload()
        {
        }
    }
}