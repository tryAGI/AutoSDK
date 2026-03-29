//HintName: G.Models.AliasesListRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AliasesListRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasesListRes" /> class.
        /// </summary>
        /// <param name="aliases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AliasesListRes(
            global::System.Collections.Generic.IList<string> aliases)
        {
            this.Aliases = aliases ?? throw new global::System.ArgumentNullException(nameof(aliases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AliasesListRes" /> class.
        /// </summary>
        public AliasesListRes()
        {
        }
    }
}