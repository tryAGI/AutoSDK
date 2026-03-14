//HintName: G.Models.ReferenceInstructionVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReferenceInstructionVariant2
    {
        /// <summary>
        /// The type of instruction, used for discrimination.<br/>
        /// Default Value: reference
        /// </summary>
        /// <default>"reference"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "reference";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceInstructionVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of instruction, used for discrimination.<br/>
        /// Default Value: reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferenceInstructionVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceInstructionVariant2" /> class.
        /// </summary>
        public ReferenceInstructionVariant2()
        {
        }
    }
}