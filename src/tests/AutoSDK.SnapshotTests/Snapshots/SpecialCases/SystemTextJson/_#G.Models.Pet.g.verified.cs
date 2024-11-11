//HintName: G.Models.Pet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Pet
    {
        /// <summary>
        /// Example: 1234
        /// </summary>
        /// <example>1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("4")]
        public string? x4 { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("1.5")]
        public bool? x15 { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("16:9")]
        public bool? x16_9 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pet" /> class.
        /// </summary>
        /// <param name="x4">
        /// Example: 1234
        /// </param>
        /// <param name="x15">
        /// Example: true
        /// </param>
        /// <param name="x16_9">
        /// Example: true
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="tag"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Pet(
            long id,
            string name,
            string? x4,
            bool? x15,
            bool? x16_9,
            string? tag)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.x4 = x4;
            this.x15 = x15;
            this.x16_9 = x16_9;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pet" /> class.
        /// </summary>
        public Pet()
        {
        }
    }
}