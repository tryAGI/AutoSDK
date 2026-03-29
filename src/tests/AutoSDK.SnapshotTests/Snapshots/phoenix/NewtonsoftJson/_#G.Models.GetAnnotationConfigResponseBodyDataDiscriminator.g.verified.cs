//HintName: G.Models.GetAnnotationConfigResponseBodyDataDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnnotationConfigResponseBodyDataDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GetAnnotationConfigResponseBodyDataDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnnotationConfigResponseBodyDataDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public GetAnnotationConfigResponseBodyDataDiscriminator(
            global::G.GetAnnotationConfigResponseBodyDataDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnnotationConfigResponseBodyDataDiscriminator" /> class.
        /// </summary>
        public GetAnnotationConfigResponseBodyDataDiscriminator()
        {
        }
    }
}