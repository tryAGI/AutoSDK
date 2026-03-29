//HintName: G.Models.CreateSetupSessionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSetupSessionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSetupSessionRequest" /> class.
        /// </summary>
        /// <param name="returnUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSetupSessionRequest(
            string? returnUrl)
        {
            this.ReturnUrl = returnUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSetupSessionRequest" /> class.
        /// </summary>
        public CreateSetupSessionRequest()
        {
        }
    }
}