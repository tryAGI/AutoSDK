//HintName: G.Models.Encoder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Encoder
    {
        /// <summary>
        /// The Encoder ID.<br/>
        /// Example: enc_1
        /// </summary>
        /// <example>enc_1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The encoder name.<br/>
        /// Example: boomerang
        /// </summary>
        /// <example>boomerang</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When this encoder is used to create an embedding, it shows the count of dimensions for the output embedding.<br/>
        /// A high dimensionality will consume more storage space, but it allows for an increase in the quality of<br/>
        /// the embedding.<br/>
        /// Example: 768
        /// </summary>
        /// <example>768</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dimensions")]
        public int? OutputDimensions { get; set; }

        /// <summary>
        /// The encoder description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the default encoder is used when creating a corpus.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// Indicates whether the encoder is enabled.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Encoder" /> class.
        /// </summary>
        /// <param name="id">
        /// The Encoder ID.<br/>
        /// Example: enc_1
        /// </param>
        /// <param name="name">
        /// The encoder name.<br/>
        /// Example: boomerang
        /// </param>
        /// <param name="outputDimensions">
        /// When this encoder is used to create an embedding, it shows the count of dimensions for the output embedding.<br/>
        /// A high dimensionality will consume more storage space, but it allows for an increase in the quality of<br/>
        /// the embedding.<br/>
        /// Example: 768
        /// </param>
        /// <param name="description">
        /// The encoder description.
        /// </param>
        /// <param name="default">
        /// Indicates whether the default encoder is used when creating a corpus.<br/>
        /// Example: true
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the encoder is enabled.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Encoder(
            string? id,
            string? name,
            int? outputDimensions,
            string? description,
            bool? @default,
            bool? enabled)
        {
            this.Id = id;
            this.Name = name;
            this.OutputDimensions = outputDimensions;
            this.Description = description;
            this.Default = @default;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Encoder" /> class.
        /// </summary>
        public Encoder()
        {
        }
    }
}