//HintName: G.Models.GetFaceDetectionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFaceDetectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("faceCrops", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetFaceDetectionResponseFaceCrop> FaceCrops { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetFaceDetectionResponseMetadata Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFaceDetectionResponse" /> class.
        /// </summary>
        /// <param name="faceCrops"></param>
        /// <param name="metadata"></param>
        public GetFaceDetectionResponse(
            global::System.Collections.Generic.IList<global::G.GetFaceDetectionResponseFaceCrop> faceCrops,
            global::G.GetFaceDetectionResponseMetadata metadata)
        {
            this.FaceCrops = faceCrops ?? throw new global::System.ArgumentNullException(nameof(faceCrops));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFaceDetectionResponse" /> class.
        /// </summary>
        public GetFaceDetectionResponse()
        {
        }
    }
}