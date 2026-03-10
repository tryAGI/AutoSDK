//HintName: G.Models.ASTLessThanOperatorNodeOutputRightDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLessThanOperatorNodeOutputRightDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ASTLessThanOperatorNodeOutputRightDiscriminatorTypeJsonConverter))]
        public global::G.ASTLessThanOperatorNodeOutputRightDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOperatorNodeOutputRightDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTLessThanOperatorNodeOutputRightDiscriminator(
            global::G.ASTLessThanOperatorNodeOutputRightDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOperatorNodeOutputRightDiscriminator" /> class.
        /// </summary>
        public ASTLessThanOperatorNodeOutputRightDiscriminator()
        {
        }
    }
}