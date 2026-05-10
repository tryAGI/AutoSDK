//HintName: G.Models.CreateTextToSpeechRequestDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToSpeechRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelJsonConverter))]
        public global::G.CreateTextToSpeechRequestDiscriminatorModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="model"></param>
        public CreateTextToSpeechRequestDiscriminator(
            global::G.CreateTextToSpeechRequestDiscriminatorModel? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToSpeechRequestDiscriminator" /> class.
        /// </summary>
        public CreateTextToSpeechRequestDiscriminator()
        {
        }

    }
}