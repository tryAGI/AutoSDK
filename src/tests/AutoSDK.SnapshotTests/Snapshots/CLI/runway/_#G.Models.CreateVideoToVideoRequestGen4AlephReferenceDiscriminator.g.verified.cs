//HintName: G.Models.CreateVideoToVideoRequestGen4AlephReferenceDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestGen4AlephReferenceDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestGen4AlephReferenceDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestGen4AlephReferenceDiscriminator(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestGen4AlephReferenceDiscriminator" /> class.
        /// </summary>
        public CreateVideoToVideoRequestGen4AlephReferenceDiscriminator()
        {
        }
    }
}