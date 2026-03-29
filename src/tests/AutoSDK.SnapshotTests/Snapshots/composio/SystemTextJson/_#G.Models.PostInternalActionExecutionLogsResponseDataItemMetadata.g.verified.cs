//HintName: G.Models.PostInternalActionExecutionLogsResponseDataItemMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostInternalActionExecutionLogsResponseDataItemMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipe_id")]
        public string? RecipeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsResponseDataItemMetadata" /> class.
        /// </summary>
        /// <param name="recipeId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostInternalActionExecutionLogsResponseDataItemMetadata(
            string? recipeId)
        {
            this.RecipeId = recipeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsResponseDataItemMetadata" /> class.
        /// </summary>
        public PostInternalActionExecutionLogsResponseDataItemMetadata()
        {
        }
    }
}