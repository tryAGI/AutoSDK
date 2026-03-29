//HintName: G.Models.TableInsertSpecPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableInsertSpecPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("row", Required = global::Newtonsoft.Json.Required.Always)]
        public object Row { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableInsertSpecPayload" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="row"></param>
        public TableInsertSpecPayload(
            int index,
            object row)
        {
            this.Index = index;
            this.Row = row ?? throw new global::System.ArgumentNullException(nameof(row));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableInsertSpecPayload" /> class.
        /// </summary>
        public TableInsertSpecPayload()
        {
        }
    }
}