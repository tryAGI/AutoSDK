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
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the engine<br/>
        /// Example: stable-diffusion-v1-5
        /// </summary>
        /// <example>stable-diffusion-v1-5</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the engine<br/>
        /// Example: Stable Diffusion v1.5
        /// </summary>
        /// <example>Stable Diffusion v1.5</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The type of content this engine produces<br/>
        /// Example: PICTURE
        /// </summary>
        /// <example>PICTURE</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EngineType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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