//HintName: G.Models.ASTLessThanOperatorNodeInputLeftDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLessThanOperatorNodeInputLeftDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ASTLessThanOperatorNodeInputLeftDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOperatorNodeInputLeftDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ASTLessThanOperatorNodeInputLeftDiscriminator(
            global::G.ASTLessThanOperatorNodeInputLeftDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOperatorNodeInputLeftDiscriminator" /> class.
        /// </summary>
        public ASTLessThanOperatorNodeInputLeftDiscriminator()
        {
        }
    }
}