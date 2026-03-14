//HintName: G.Models.BulkDeleteDocumentsResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkDeleteDocumentsResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_type")]
        public global::G.BulkDeleteDocumentsResponseDiscriminatorResponseType? ResponseType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteDocumentsResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="responseType"></param>
        public BulkDeleteDocumentsResponseDiscriminator(
            global::G.BulkDeleteDocumentsResponseDiscriminatorResponseType? responseType)
        {
            this.ResponseType = responseType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkDeleteDocumentsResponseDiscriminator" /> class.
        /// </summary>
        public BulkDeleteDocumentsResponseDiscriminator()
        {
        }
    }
}