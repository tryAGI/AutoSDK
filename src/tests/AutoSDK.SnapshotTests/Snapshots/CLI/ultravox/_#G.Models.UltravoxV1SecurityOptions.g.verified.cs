//HintName: G.Models.UltravoxV1SecurityOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The different options for satisfying a tool's security requirements.
    /// </summary>
    public sealed partial class UltravoxV1SecurityOptions
    {
        /// <summary>
        /// The options for security. Only one must be met. The first one that can be<br/>
        ///  satisfied will be used in general. The single exception to this rule is<br/>
        ///  that we always prefer a non-empty set of requirements over an empty set<br/>
        ///  unless no non-empty set can be satisfied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1SecurityRequirements>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SecurityOptions" /> class.
        /// </summary>
        /// <param name="options">
        /// The options for security. Only one must be met. The first one that can be<br/>
        ///  satisfied will be used in general. The single exception to this rule is<br/>
        ///  that we always prefer a non-empty set of requirements over an empty set<br/>
        ///  unless no non-empty set can be satisfied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1SecurityOptions(
            global::System.Collections.Generic.IList<global::G.UltravoxV1SecurityRequirements>? options)
        {
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SecurityOptions" /> class.
        /// </summary>
        public UltravoxV1SecurityOptions()
        {
        }
    }
}