//HintName: G.Models.ModelsResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsResponse200
    {
        /// <summary>
        /// Type of object (list).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The available models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItems>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsResponse200" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of object (list).
        /// </param>
        /// <param name="data">
        /// The available models.
        /// </param>
        public ModelsResponse200(
            string? @object,
            global::System.Collections.Generic.IList<global::G.ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItems>? data)
        {
            this.Object = @object;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsResponse200" /> class.
        /// </summary>
        public ModelsResponse200()
        {
        }
    }
}