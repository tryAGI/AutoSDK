//HintName: G.Models.SessionsCreateRequestBrowserSettingsContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsCreateRequestBrowserSettingsContext
    {
        /// <summary>
        /// The Context ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether or not to persist the context after browsing. Defaults to `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persist")]
        public bool? Persist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsCreateRequestBrowserSettingsContext" /> class.
        /// </summary>
        /// <param name="id">
        /// The Context ID.
        /// </param>
        /// <param name="persist">
        /// Whether or not to persist the context after browsing. Defaults to `false`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionsCreateRequestBrowserSettingsContext(
            string id,
            bool? persist)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Persist = persist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsCreateRequestBrowserSettingsContext" /> class.
        /// </summary>
        public SessionsCreateRequestBrowserSettingsContext()
        {
        }
    }
}