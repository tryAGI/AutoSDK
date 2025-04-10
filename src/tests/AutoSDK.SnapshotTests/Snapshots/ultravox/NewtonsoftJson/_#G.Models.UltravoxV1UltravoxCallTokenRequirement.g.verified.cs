//HintName: G.Models.UltravoxV1UltravoxCallTokenRequirement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A security requirement that will automatically be fulfilled during call creation.<br/>
    ///  The generated token will be set as an X-Ultravox-Call-Token header when the tool<br/>
    ///  is invoked. The token is only verifiable by the Ultravox service and should not be<br/>
    ///  used for authentication by any other service.<br/>
    ///  The token will also be invalid as soon as the call is completed.
    /// </summary>
    public sealed partial class UltravoxV1UltravoxCallTokenRequirement
    {
        /// <summary>
        /// The scopes that must be present in the token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1UltravoxCallTokenRequirement" /> class.
        /// </summary>
        /// <param name="scopes">
        /// The scopes that must be present in the token.
        /// </param>
        public UltravoxV1UltravoxCallTokenRequirement(
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1UltravoxCallTokenRequirement" /> class.
        /// </summary>
        public UltravoxV1UltravoxCallTokenRequirement()
        {
        }
    }
}