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
        [global::Newtonsoft.Json.JsonProperty("setupUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string SetupUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSetupSessionResponse" /> class.
        /// </summary>
        /// <param name="setupUrl"></param>
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