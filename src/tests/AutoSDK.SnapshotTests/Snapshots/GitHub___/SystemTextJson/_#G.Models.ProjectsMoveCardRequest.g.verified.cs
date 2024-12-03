//HintName: G.Models.ProjectsMoveCardRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsMoveCardRequest
    {
        /// <summary>
        /// The position of the card in a column. Can be one of: `top`, `bottom`, or `after:&lt;card_id&gt;` to place after the specified card.<br/>
        /// Example: bottom
        /// </summary>
        /// <example>bottom</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Position { get; set; }

        /// <summary>
        /// The unique identifier of the column the card should be moved to<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_id")]
        public int? ColumnId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsMoveCardRequest" /> class.
        /// </summary>
        /// <param name="position">
        /// The position of the card in a column. Can be one of: `top`, `bottom`, or `after:&lt;card_id&gt;` to place after the specified card.<br/>
        /// Example: bottom
        /// </param>
        /// <param name="columnId">
        /// The unique identifier of the column the card should be moved to<br/>
        /// Example: 42
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProjectsMoveCardRequest(
            string position,
            int? columnId)
        {
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.ColumnId = columnId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsMoveCardRequest" /> class.
        /// </summary>
        public ProjectsMoveCardRequest()
        {
        }
    }
}