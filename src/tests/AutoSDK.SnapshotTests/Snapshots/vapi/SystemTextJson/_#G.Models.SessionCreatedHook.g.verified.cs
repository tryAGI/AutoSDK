//HintName: G.Models.SessionCreatedHook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionCreatedHook
    {
        /// <summary>
        /// This is the event that triggers this hook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionCreatedHookOnJsonConverter))]
        public global::G.SessionCreatedHookOn On { get; set; }

        /// <summary>
        /// This is the set of actions to perform when the hook triggers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ToolCallHookAction> Do { get; set; }

        /// <summary>
        /// Optional name for this hook instance.<br/>
        /// If no name is provided, the hook will be auto generated as UUID.<br/>
        /// @default UUID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCreatedHook" /> class.
        /// </summary>
        /// <param name="do">
        /// This is the set of actions to perform when the hook triggers.
        /// </param>
        /// <param name="on">
        /// This is the event that triggers this hook
        /// </param>
        /// <param name="name">
        /// Optional name for this hook instance.<br/>
        /// If no name is provided, the hook will be auto generated as UUID.<br/>
        /// @default UUID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionCreatedHook(
            global::System.Collections.Generic.IList<global::G.ToolCallHookAction> @do,
            global::G.SessionCreatedHookOn on,
            string? name)
        {
            this.On = on;
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCreatedHook" /> class.
        /// </summary>
        public SessionCreatedHook()
        {
        }
    }
}