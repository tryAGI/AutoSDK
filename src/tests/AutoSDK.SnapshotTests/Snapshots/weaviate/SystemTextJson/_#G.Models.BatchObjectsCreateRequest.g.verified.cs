//HintName: G.Models.BatchObjectsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchObjectsCreateRequest
    {
        /// <summary>
        /// Define which fields need to be returned. Default value is ALL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<global::G.BatchObjectsCreateRequestField>? Fields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects")]
        public global::System.Collections.Generic.IList<global::G.Object>? Objects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectsCreateRequest" /> class.
        /// </summary>
        /// <param name="fields">
        /// Define which fields need to be returned. Default value is ALL
        /// </param>
        /// <param name="objects"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BatchObjectsCreateRequest(
            global::System.Collections.Generic.IList<global::G.BatchObjectsCreateRequestField>? fields,
            global::System.Collections.Generic.IList<global::G.Object>? objects)
        {
            this.Fields = fields;
            this.Objects = objects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectsCreateRequest" /> class.
        /// </summary>
        public BatchObjectsCreateRequest()
        {
        }
    }
}