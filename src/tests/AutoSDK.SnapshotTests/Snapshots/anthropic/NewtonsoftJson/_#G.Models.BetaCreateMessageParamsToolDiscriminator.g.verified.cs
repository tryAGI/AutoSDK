//HintName: G.Models.BetaCreateMessageParamsToolDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCreateMessageParamsToolDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaCreateMessageParamsToolDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateMessageParamsToolDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public BetaCreateMessageParamsToolDiscriminator(
            global::G.BetaCreateMessageParamsToolDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateMessageParamsToolDiscriminator" /> class.
        /// </summary>
        public BetaCreateMessageParamsToolDiscriminator()
        {
        }
    }
}