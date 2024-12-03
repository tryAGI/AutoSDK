//HintName: G.Models.CustomChartsSectionCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartsSectionCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionCreate" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CustomChartsSectionCreate(
            string title,
            string? description,
            int? index)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionCreate" /> class.
        /// </summary>
        public CustomChartsSectionCreate()
        {
        }
    }
}