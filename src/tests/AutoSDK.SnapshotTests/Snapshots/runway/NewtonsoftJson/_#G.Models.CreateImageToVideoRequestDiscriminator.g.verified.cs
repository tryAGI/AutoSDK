//HintName: G.Models.CreateImageToVideoRequestDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageToVideoRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateImageToVideoRequestDiscriminatorModelJsonConverter))]
        public global::G.CreateImageToVideoRequestDiscriminatorModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="model"></param>
        public CreateImageToVideoRequestDiscriminator(
            global::G.CreateImageToVideoRequestDiscriminatorModel? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageToVideoRequestDiscriminator" /> class.
        /// </summary>
        public CreateImageToVideoRequestDiscriminator()
        {
        }

    }
}