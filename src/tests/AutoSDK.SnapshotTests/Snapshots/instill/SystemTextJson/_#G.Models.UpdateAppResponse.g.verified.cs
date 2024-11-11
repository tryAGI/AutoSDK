//HintName: G.Models.UpdateAppResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateAppResponse represents a response for updating a app.
    /// </summary>
    public sealed partial class UpdateAppResponse
    {
        /// <summary>
        /// The updated app.<br/>
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
        /// Initializes a new instance of the <see cref="UpdateAppResponse" /> class.
        /// </summary>
        /// <param name="app">
        /// The updated app.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateAppResponse(
            global::G.App? app)
        {
            this.App = app;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAppResponse" /> class.
        /// </summary>
        public UpdateAppResponse()
        {
        }
    }
}