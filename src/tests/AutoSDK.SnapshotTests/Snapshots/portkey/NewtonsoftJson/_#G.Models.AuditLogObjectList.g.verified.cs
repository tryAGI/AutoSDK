//HintName: G.Models.AuditLogObjectList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuditLogObjectList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("records")]
        public global::System.Collections.Generic.IList<global::G.AuditLogObjectListRecord>? Records { get; set; }

        /// <summary>
        /// Total number of records in the response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AuditLogObjectListObjectJsonConverter))]
        public global::G.AuditLogObjectListObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogObjectList" /> class.
        /// </summary>
        /// <param name="records"></param>
        /// <param name="total">
        /// Total number of records in the response
        /// </param>
        /// <param name="object">
        /// The type of object being returned
        /// </param>
        public AuditLogObjectList(
            global::System.Collections.Generic.IList<global::G.AuditLogObjectListRecord>? records,
            int? total,
            global::G.AuditLogObjectListObject? @object)
        {
            this.Records = records;
            this.Total = total;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogObjectList" /> class.
        /// </summary>
        public AuditLogObjectList()
        {
        }
    }
}