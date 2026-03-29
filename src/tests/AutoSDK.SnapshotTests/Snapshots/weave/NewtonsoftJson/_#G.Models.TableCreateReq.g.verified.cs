//HintName: G.Models.TableCreateReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableCreateReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("table", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TableSchemaForInsert Table { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableCreateReq" /> class.
        /// </summary>
        /// <param name="table"></param>
        public TableCreateReq(
            global::G.TableSchemaForInsert table)
        {
            this.Table = table ?? throw new global::System.ArgumentNullException(nameof(table));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableCreateReq" /> class.
        /// </summary>
        public TableCreateReq()
        {
        }
    }
}