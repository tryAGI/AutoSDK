//HintName: G.Models.RequestImageBlockSourceDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestImageBlockSourceDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RequestImageBlockSourceDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestImageBlockSourceDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public RequestImageBlockSourceDiscriminator(
            global::G.RequestImageBlockSourceDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestImageBlockSourceDiscriminator" /> class.
        /// </summary>
        public RequestImageBlockSourceDiscriminator()
        {
        }
    }
}