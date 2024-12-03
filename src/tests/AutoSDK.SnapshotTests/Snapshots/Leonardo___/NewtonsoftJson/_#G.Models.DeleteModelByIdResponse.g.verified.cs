//HintName: G.Models.DeleteModelByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteModelByIdResponse
    {
        /// <summary>
        /// columns and relationships of "custom_models"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_custom_models_by_pk")]
        public global::G.DeleteModelByIdResponseDeleteCustomModelsByPk? DeleteCustomModelsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteModelByIdResponse" /> class.
        /// </summary>
        /// <param name="deleteCustomModelsByPk">
        /// columns and relationships of "custom_models"
        /// </param>
        public DeleteModelByIdResponse(
            global::G.DeleteModelByIdResponseDeleteCustomModelsByPk? deleteCustomModelsByPk)
        {
            this.DeleteCustomModelsByPk = deleteCustomModelsByPk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteModelByIdResponse" /> class.
        /// </summary>
        public DeleteModelByIdResponse()
        {
        }
    }
}