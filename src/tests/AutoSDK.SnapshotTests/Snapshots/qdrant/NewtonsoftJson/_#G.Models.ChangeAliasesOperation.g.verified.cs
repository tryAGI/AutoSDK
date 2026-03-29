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
        [global::Newtonsoft.Json.JsonProperty("actions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AliasOperations> Actions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeAliasesOperation" /> class.
        /// </summary>
        /// <param name="actions"></param>
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