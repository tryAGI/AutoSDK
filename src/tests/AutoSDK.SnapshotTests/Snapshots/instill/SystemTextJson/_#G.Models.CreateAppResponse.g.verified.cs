//HintName: G.Models.CreateAppResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CreateAppResponse represents a response for creating a app.
    /// </summary>
    public sealed partial class CreateAppResponse
    {
        /// <summary>
        /// The created app.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::G.App? App { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAppResponse" /> class.
        /// </summary>
        /// <param name="app">
        /// The created app.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateAppResponse(
            global::G.App? app)
        {
            this.App = app;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAppResponse" /> class.
        /// </summary>
        public CreateAppResponse()
        {
        }
    }
}