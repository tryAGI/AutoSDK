//HintName: G.Models.ASTOrOperatorNodeInputChildrenItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTOrOperatorNodeInputChildrenItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ASTOrOperatorNodeInputChildrenItemDiscriminatorTypeJsonConverter))]
        public global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTOrOperatorNodeInputChildrenItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ASTOrOperatorNodeInputChildrenItemDiscriminator(
            global::G.ASTOrOperatorNodeInputChildrenItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTOrOperatorNodeInputChildrenItemDiscriminator" /> class.
        /// </summary>
        public ASTOrOperatorNodeInputChildrenItemDiscriminator()
        {
        }
    }
}