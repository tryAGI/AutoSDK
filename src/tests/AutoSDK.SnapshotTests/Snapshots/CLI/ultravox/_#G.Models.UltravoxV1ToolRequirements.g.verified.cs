//HintName: G.Models.UltravoxV1ToolRequirements.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The requirements for using a tool, which must be satisfied when creating a call with the tool.
    /// </summary>
    public sealed partial class UltravoxV1ToolRequirements
    {
        /// <summary>
        /// Security requirements for an HTTP tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpSecurityOptions")]
        public global::G.UltravoxV1SecurityOptions? HttpSecurityOptions { get; set; }

        /// <summary>
        /// Dynamic parameters that must be overridden with an explicit (static) value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requiredParameterOverrides")]
        public global::System.Collections.Generic.IList<string>? RequiredParameterOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ToolRequirements" /> class.
        /// </summary>
        /// <param name="httpSecurityOptions">
        /// Security requirements for an HTTP tool.
        /// </param>
        /// <param name="requiredParameterOverrides">
        /// Dynamic parameters that must be overridden with an explicit (static) value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1ToolRequirements(
            global::G.UltravoxV1SecurityOptions? httpSecurityOptions,
            global::System.Collections.Generic.IList<string>? requiredParameterOverrides)
        {
            this.HttpSecurityOptions = httpSecurityOptions;
            this.RequiredParameterOverrides = requiredParameterOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ToolRequirements" /> class.
        /// </summary>
        public UltravoxV1ToolRequirements()
        {
        }
    }
}