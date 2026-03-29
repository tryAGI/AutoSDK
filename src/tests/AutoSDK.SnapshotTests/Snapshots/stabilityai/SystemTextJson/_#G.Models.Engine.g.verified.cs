//HintName: G.Models.Engine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Engine
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Unique identifier for the engine<br/>
        /// Example: stable-diffusion-v1-5
        /// </summary>
        /// <example>stable-diffusion-v1-5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the engine<br/>
        /// Example: Stable Diffusion v1.5
        /// </summary>
        /// <example>Stable Diffusion v1.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of content this engine produces<br/>
        /// Example: PICTURE
        /// </summary>
        /// <example>PICTURE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EngineTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EngineType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Engine" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="id">
        /// Unique identifier for the engine<br/>
        /// Example: stable-diffusion-v1-5
        /// </param>
        /// <param name="name">
        /// Name of the engine<br/>
        /// Example: Stable Diffusion v1.5
        /// </param>
        /// <param name="type">
        /// The type of content this engine produces<br/>
        /// Example: PICTURE
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Engine(
            string description,
            string id,
            string name,
            global::G.EngineType type)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Engine" /> class.
        /// </summary>
        public Engine()
        {
        }
    }
}