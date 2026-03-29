//HintName: G.Models.Delete1Response4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Delete1Response4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Knowledge { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deletedDocuments", Required = global::Newtonsoft.Json.Required.Always)]
        public object DeletedDocuments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Delete1Response4" /> class.
        /// </summary>
        /// <param name="knowledge"></param>
        /// <param name="deletedDocuments"></param>
        public Delete1Response4(
            bool knowledge,
            object deletedDocuments)
        {
            this.Knowledge = knowledge;
            this.DeletedDocuments = deletedDocuments ?? throw new global::System.ArgumentNullException(nameof(deletedDocuments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Delete1Response4" /> class.
        /// </summary>
        public Delete1Response4()
        {
        }
    }
}