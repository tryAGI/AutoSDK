//HintName: G.Models.CreateSoundEffectRequestDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSoundEffectRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSoundEffectRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="model"></param>
        public CreateSoundEffectRequestDiscriminator(
            string? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSoundEffectRequestDiscriminator" /> class.
        /// </summary>
        public CreateSoundEffectRequestDiscriminator()
        {
        }
    }
}