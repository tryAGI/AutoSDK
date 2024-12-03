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
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_init_images_by_pk")]
        public global::G.DeleteInitImageByIdResponseDeleteInitImagesByPk? DeleteInitImagesByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInitImageByIdResponse" /> class.
        /// </summary>
        /// <param name="deleteInitImagesByPk">
        /// columns and relationships of "init_images"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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