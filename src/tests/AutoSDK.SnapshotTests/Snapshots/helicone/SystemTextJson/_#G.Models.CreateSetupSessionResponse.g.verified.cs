//HintName: G.Models.CreateSetupSessionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSetupSessionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setupUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SetupUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSetupSessionResponse" /> class.
        /// </summary>
        /// <param name="setupUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSetupSessionResponse(
            string setupUrl)
        {
            this.SetupUrl = setupUrl ?? throw new global::System.ArgumentNullException(nameof(setupUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSetupSessionResponse" /> class.
        /// </summary>
        public CreateSetupSessionResponse()
        {
        }
    }
}