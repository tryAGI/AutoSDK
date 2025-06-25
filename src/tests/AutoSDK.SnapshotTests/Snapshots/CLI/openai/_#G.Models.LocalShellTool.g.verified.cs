//HintName: G.Models.LocalShellTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that allows the model to execute shell commands in a local environment.
    /// </summary>
    public sealed partial class LocalShellTool
    {
        /// <summary>
        /// The type of the local shell tool. Always `local_shell`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LocalShellToolTypeJsonConverter))]
        public global::G.LocalShellToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShellTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the local shell tool. Always `local_shell`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalShellTool(
            global::G.LocalShellToolType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShellTool" /> class.
        /// </summary>
        public LocalShellTool()
        {
        }
    }
}