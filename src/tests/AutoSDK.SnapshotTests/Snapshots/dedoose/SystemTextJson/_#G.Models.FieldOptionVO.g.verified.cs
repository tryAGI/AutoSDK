//HintName: G.Models.FieldOptionVO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FieldOptionVO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exitingOptionId")]
        public global::System.Guid? ExitingOptionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldOptionVO" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="sortOrder"></param>
        /// <param name="exitingOptionId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FieldOptionVO(
            string? title,
            int? sortOrder,
            global::System.Guid? exitingOptionId)
        {
            this.Title = title;
            this.SortOrder = sortOrder;
            this.ExitingOptionId = exitingOptionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldOptionVO" /> class.
        /// </summary>
        public FieldOptionVO()
        {
        }
    }
}