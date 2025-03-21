//HintName: G.Models.BatchErrors.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchErrors
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.BatchErrorsDataItem>? Data { get; set; }

        /// <summary>
        /// The object type, which is always `list`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchErrors" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="object">
        /// The object type, which is always `list`.
        /// </param>
        public BatchErrors(
            global::System.Collections.Generic.IList<global::G.BatchErrorsDataItem>? data,
            string? @object)
        {
            this.Data = data;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchErrors" /> class.
        /// </summary>
        public BatchErrors()
        {
        }
    }
}