//HintName: G.Models.UpdateLabelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateLabelRequest
    {
        /// <summary>
        /// Name of the label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Color code for the label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_code")]
        public string? ColorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLabelRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the label
        /// </param>
        /// <param name="description">
        /// Description of the label
        /// </param>
        /// <param name="colorCode">
        /// Color code for the label
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateLabelRequest(
            string? name,
            string? description,
            string? colorCode)
        {
            this.Name = name;
            this.Description = description;
            this.ColorCode = colorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLabelRequest" /> class.
        /// </summary>
        public UpdateLabelRequest()
        {
        }
    }
}