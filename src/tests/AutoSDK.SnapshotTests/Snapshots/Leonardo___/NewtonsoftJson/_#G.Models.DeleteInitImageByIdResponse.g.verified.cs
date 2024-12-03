//HintName: G.Models.DeleteInitImageByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteInitImageByIdResponse
    {
        /// <summary>
        /// columns and relationships of "init_images"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_init_images_by_pk")]
        public global::G.DeleteInitImageByIdResponseDeleteInitImagesByPk? DeleteInitImagesByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInitImageByIdResponse" /> class.
        /// </summary>
        /// <param name="deleteInitImagesByPk">
        /// columns and relationships of "init_images"
        /// </param>
        public DeleteInitImageByIdResponse(
            global::G.DeleteInitImageByIdResponseDeleteInitImagesByPk? deleteInitImagesByPk)
        {
            this.DeleteInitImagesByPk = deleteInitImagesByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInitImageByIdResponse" /> class.
        /// </summary>
        public DeleteInitImageByIdResponse()
        {
        }
    }
}