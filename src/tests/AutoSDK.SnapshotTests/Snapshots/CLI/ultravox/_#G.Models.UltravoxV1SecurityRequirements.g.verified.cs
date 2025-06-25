//HintName: G.Models.UltravoxV1SecurityRequirements.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The security requirements for a request. All requirements must be met.
    /// </summary>
    public sealed partial class UltravoxV1SecurityRequirements
    {
        /// <summary>
        /// Requirements keyed by name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::System.Collections.Generic.Dictionary<string, global::G.UltravoxV1SecurityRequirement>? Requirements { get; set; }

        /// <summary>
        /// An additional special security requirement that can be automatically fulfilled<br/>
        ///  during call creation. If a tool has this requirement set, a token identifying<br/>
        ///  the call and relevant scopes will be created during call creation and set as<br/>
        ///  an X-Ultravox-Call-Token header when the tool is invoked.<br/>
        ///  Such tokens are only verifiable by the Ultravox service and primarily exist<br/>
        ///  for built-in tools (though it's possible for third-party tools that wrap a<br/>
        ///  built-in tool to make use of them as well).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ultravoxCallTokenRequirement")]
        public global::G.UltravoxV1UltravoxCallTokenRequirement? UltravoxCallTokenRequirement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SecurityRequirements" /> class.
        /// </summary>
        /// <param name="requirements">
        /// Requirements keyed by name.
        /// </param>
        /// <param name="ultravoxCallTokenRequirement">
        /// An additional special security requirement that can be automatically fulfilled<br/>
        ///  during call creation. If a tool has this requirement set, a token identifying<br/>
        ///  the call and relevant scopes will be created during call creation and set as<br/>
        ///  an X-Ultravox-Call-Token header when the tool is invoked.<br/>
        ///  Such tokens are only verifiable by the Ultravox service and primarily exist<br/>
        ///  for built-in tools (though it's possible for third-party tools that wrap a<br/>
        ///  built-in tool to make use of them as well).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1SecurityRequirements(
            global::System.Collections.Generic.Dictionary<string, global::G.UltravoxV1SecurityRequirement>? requirements,
            global::G.UltravoxV1UltravoxCallTokenRequirement? ultravoxCallTokenRequirement)
        {
            this.Requirements = requirements;
            this.UltravoxCallTokenRequirement = ultravoxCallTokenRequirement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SecurityRequirements" /> class.
        /// </summary>
        public UltravoxV1SecurityRequirements()
        {
        }
    }
}