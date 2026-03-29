//HintName: G.Models.TemplatesForkTemplateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesForkTemplateRequest
    {
        /// <summary>
        /// Optional custom name for the forked template. If not provided, a random name will be generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesForkTemplateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Optional custom name for the forked template. If not provided, a random name will be generated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesForkTemplateRequest(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesForkTemplateRequest" /> class.
        /// </summary>
        public TemplatesForkTemplateRequest()
        {
        }
    }
}