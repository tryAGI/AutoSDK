//HintName: G.Models.UpdateExportResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateExportResponse
    {
        /// <summary>
        /// The unique identifier of the updated export
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The total number of items in the export
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// The type of the object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdateExportResponseObjectJsonConverter))]
        public global::G.UpdateExportResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExportResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the updated export
        /// </param>
        /// <param name="total">
        /// The total number of items in the export
        /// </param>
        /// <param name="object">
        /// The type of the object
        /// </param>
        public UpdateExportResponse(
            global::System.Guid id,
            int total,
            global::G.UpdateExportResponseObject @object)
        {
            this.Id = id;
            this.Total = total;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExportResponse" /> class.
        /// </summary>
        public UpdateExportResponse()
        {
        }
    }
}