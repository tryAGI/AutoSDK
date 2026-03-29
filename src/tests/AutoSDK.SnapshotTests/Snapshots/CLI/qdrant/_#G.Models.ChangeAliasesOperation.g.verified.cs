//HintName: G.Models.ChangeAliasesOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operation for performing changes of collection aliases. Alias changes are atomic, meaning that no collection modifications can happen between alias operations.
    /// </summary>
    public sealed partial class ChangeAliasesOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AliasOperations> Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeAliasesOperation" /> class.
        /// </summary>
        /// <param name="actions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChangeAliasesOperation(
            global::System.Collections.Generic.IList<global::G.AliasOperations> actions)
        {
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeAliasesOperation" /> class.
        /// </summary>
        public ChangeAliasesOperation()
        {
        }
    }
}