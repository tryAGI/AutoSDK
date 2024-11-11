//HintName: G.Models.GetInitImageByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInitImageByIdResponse
    {
        /// <summary>
        /// columns and relationships of "init_images"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("init_images_by_pk")]
        public global::G.GetInitImageByIdResponseInitImagesByPk? InitImagesByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInitImageByIdResponse" /> class.
        /// </summary>
        /// <param name="initImagesByPk">
        /// columns and relationships of "init_images"
        /// </param>
        public GetInitImageByIdResponse(
            global::G.GetInitImageByIdResponseInitImagesByPk? initImagesByPk)
        {
            this.InitImagesByPk = initImagesByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInitImageByIdResponse" /> class.
        /// </summary>
        public GetInitImageByIdResponse()
        {
        }
    }
}