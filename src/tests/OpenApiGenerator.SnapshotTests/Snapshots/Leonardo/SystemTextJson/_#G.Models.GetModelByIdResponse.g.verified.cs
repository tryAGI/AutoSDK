//HintName: G.Models.GetModelByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelByIdResponse
    {
        /// <summary>
        /// columns and relationships of "custom_models"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_models_by_pk")]
        public global::G.GetModelByIdResponseCustomModelsByPk? CustomModelsByPk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}