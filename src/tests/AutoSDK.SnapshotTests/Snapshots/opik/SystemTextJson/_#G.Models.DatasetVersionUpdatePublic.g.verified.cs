//HintName: G.Models.DatasetVersionUpdatePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetVersionUpdatePublic
    {
        /// <summary>
        /// Optional description of changes in this version<br/>
        /// Example: Updated baseline version
        /// </summary>
        /// <example>Updated baseline version</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("change_description")]
        public string? ChangeDescription { get; set; }

        /// <summary>
        /// Optional list of tags to add to this version<br/>
        /// Example: [production, reviewed]
        /// </summary>
        /// <example>[production, reviewed]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_to_add")]
        public global::System.Collections.Generic.IList<string>? TagsToAdd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionUpdatePublic" /> class.
        /// </summary>
        /// <param name="changeDescription">
        /// Optional description of changes in this version<br/>
        /// Example: Updated baseline version
        /// </param>
        /// <param name="tagsToAdd">
        /// Optional list of tags to add to this version<br/>
        /// Example: [production, reviewed]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetVersionUpdatePublic(
            string? changeDescription,
            global::System.Collections.Generic.IList<string>? tagsToAdd)
        {
            this.ChangeDescription = changeDescription;
            this.TagsToAdd = tagsToAdd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionUpdatePublic" /> class.
        /// </summary>
        public DatasetVersionUpdatePublic()
        {
        }
    }
}