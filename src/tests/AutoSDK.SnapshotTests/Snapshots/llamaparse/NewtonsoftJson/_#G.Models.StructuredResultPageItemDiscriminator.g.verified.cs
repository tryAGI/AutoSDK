//HintName: G.Models.StructuredResultPageItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredResultPageItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.StructuredResultPageItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredResultPageItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public StructuredResultPageItemDiscriminator(
            global::G.StructuredResultPageItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredResultPageItemDiscriminator" /> class.
        /// </summary>
        public StructuredResultPageItemDiscriminator()
        {
        }
    }
}