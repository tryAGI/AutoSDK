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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The encoder name.<br/>
        /// Example: boomerang
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When this encoder is used to create an embedding, it shows the count of dimensions for the output embedding.<br/>
        /// A high dimensionality will consume more storage space, but it allows for an increase the quality of<br/>
        /// the embedding.<br/>
        /// Example: 768
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dimensions")]
        public int? OutputDimensions { get; set; }

        /// <summary>
        /// The encoder description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the encoder is default used when creating a corpus.<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// Indicates whether the encoder is enabled.<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}