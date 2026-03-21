//HintName: G.Models.CreateVoiceDubbingRequestDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceDubbingRequestDiscriminator
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
        /// Initializes a new instance of the <see cref="CreateVoiceDubbingRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="model"></param>
        public CreateVoiceDubbingRequestDiscriminator(
            string? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceDubbingRequestDiscriminator" /> class.
        /// </summary>
        public CreateVoiceDubbingRequestDiscriminator()
        {
        }
    }
}