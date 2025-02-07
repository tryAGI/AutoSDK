//HintName: G.Models.FieldInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FieldInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typeInt")]
        public int? TypeInt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listOptions")]
        public global::System.Collections.Generic.IList<string>? ListOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDynamic")]
        public bool? IsDynamic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldInfo" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="typeInt"></param>
        /// <param name="listOptions"></param>
        /// <param name="isDynamic"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FieldInfo(
            string? title,
            string? description,
            int? typeInt,
            global::System.Collections.Generic.IList<string>? listOptions,
            bool? isDynamic)
        {
            this.Title = title;
            this.Description = description;
            this.TypeInt = typeInt;
            this.ListOptions = listOptions;
            this.IsDynamic = isDynamic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldInfo" /> class.
        /// </summary>
        public FieldInfo()
        {
        }
    }
}