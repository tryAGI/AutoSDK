//HintName: G.Models.TableAppendSpecPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableAppendSpecPayload
    {
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
        /// Initializes a new instance of the <see cref="TableAppendSpecPayload" /> class.
        /// </summary>
        /// <param name="row"></param>
        public TableAppendSpecPayload(
            object row)
        {
            this.Row = row ?? throw new global::System.ArgumentNullException(nameof(row));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableAppendSpecPayload" /> class.
        /// </summary>
        public TableAppendSpecPayload()
        {
        }
    }
}