//HintName: G.Models.UpdateAnnotationConfigResponseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAnnotationConfigResponseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Data6 Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnnotationConfigResponseBody" /> class.
        /// </summary>
        /// <param name="data"></param>
        public UpdateAnnotationConfigResponseBody(
            global::G.Data6 data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnnotationConfigResponseBody" /> class.
        /// </summary>
        public UpdateAnnotationConfigResponseBody()
        {
        }
    }
}