//HintName: G.Models.PostToolRouterSessionBySessionIdSearchRequestQuerie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchRequestQuerie
    {
        /// <summary>
        /// The task or use case to search tools for. Provide a detailed description to get the best results.<br/>
        /// Example: Send an email to john@example.com with a summary of my last 5 slack messages
        /// </summary>
        /// <example>Send an email to john@example.com with a summary of my last 5 slack messages</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_case")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UseCase { get; set; }

        /// <summary>
        /// Known field hints as key:value pairs (e.g., "channel_name:general, user_email:john@example.com")<br/>
        /// Example: channel_name:general
        /// </summary>
        /// <example>channel_name:general</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("known_fields")]
        public string? KnownFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchRequestQuerie" /> class.
        /// </summary>
        /// <param name="useCase">
        /// The task or use case to search tools for. Provide a detailed description to get the best results.<br/>
        /// Example: Send an email to john@example.com with a summary of my last 5 slack messages
        /// </param>
        /// <param name="knownFields">
        /// Known field hints as key:value pairs (e.g., "channel_name:general, user_email:john@example.com")<br/>
        /// Example: channel_name:general
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchRequestQuerie(
            string useCase,
            string? knownFields)
        {
            this.UseCase = useCase ?? throw new global::System.ArgumentNullException(nameof(useCase));
            this.KnownFields = knownFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchRequestQuerie" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchRequestQuerie()
        {
        }
    }
}