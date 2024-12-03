//HintName: G.Models.TagValueUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TagValueUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagValueUpdate" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="description"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TagValueUpdate(
            string? value,
            string? description)
        {
            this.Value = value;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagValueUpdate" /> class.
        /// </summary>
        public TagValueUpdate()
        {
        }
    }
}