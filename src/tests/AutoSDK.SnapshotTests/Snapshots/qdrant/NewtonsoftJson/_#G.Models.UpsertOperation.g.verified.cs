//HintName: G.Models.UpsertOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upsert", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PointInsertOperations Upsert { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertOperation" /> class.
        /// </summary>
        /// <param name="upsert"></param>
        public UpsertOperation(
            global::G.PointInsertOperations upsert)
        {
            this.Upsert = upsert;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertOperation" /> class.
        /// </summary>
        public UpsertOperation()
        {
        }
    }
}