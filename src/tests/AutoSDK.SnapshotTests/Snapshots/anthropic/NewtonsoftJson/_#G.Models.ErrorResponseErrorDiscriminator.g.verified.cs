//HintName: G.Models.ErrorResponseErrorDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorResponseErrorDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ErrorResponseErrorDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseErrorDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ErrorResponseErrorDiscriminator(
            global::G.ErrorResponseErrorDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseErrorDiscriminator" /> class.
        /// </summary>
        public ErrorResponseErrorDiscriminator()
        {
        }
    }
}