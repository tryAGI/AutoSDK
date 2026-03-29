//HintName: G.Models.MedicalComprehendResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MedicalComprehendResponse
    {
        /// <summary>
        /// An array of medical entities extracted from the input text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MedicalComprehendEntity> Entities { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalComprehendResponse" /> class.
        /// </summary>
        /// <param name="entities">
        /// An array of medical entities extracted from the input text.
        /// </param>
        public MedicalComprehendResponse(
            global::System.Collections.Generic.IList<global::G.MedicalComprehendEntity> entities)
        {
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalComprehendResponse" /> class.
        /// </summary>
        public MedicalComprehendResponse()
        {
        }
    }
}