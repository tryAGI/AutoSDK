//HintName: G.Models.ExportDtoVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportDtoVariant1
    {
        /// <summary>
        /// The id of the agent that the export will run for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The start of the time range for the export.  If not provided, the export will start from the beginning of the agent's data<br/>
        /// Example: 2024-05-15T12:00:00Z
        /// </summary>
        /// <example>2024-05-15T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// The end of the time range for the export. If not provided, the export will run until the current time<br/>
        /// Example: 2024-05-15T12:00:00Z
        /// </summary>
        /// <example>2024-05-15T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// Determines if the export should fetch persistent chats. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persistent_chats")]
        public bool? PersistentChats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportDtoVariant1" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The id of the agent that the export will run for
        /// </param>
        /// <param name="from">
        /// The start of the time range for the export.  If not provided, the export will start from the beginning of the agent's data<br/>
        /// Example: 2024-05-15T12:00:00Z
        /// </param>
        /// <param name="to">
        /// The end of the time range for the export. If not provided, the export will run until the current time<br/>
        /// Example: 2024-05-15T12:00:00Z
        /// </param>
        /// <param name="persistentChats">
        /// Determines if the export should fetch persistent chats. Defaults to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportDtoVariant1(
            string agentId,
            string? from,
            string? to,
            bool? persistentChats)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.From = from;
            this.To = to;
            this.PersistentChats = persistentChats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportDtoVariant1" /> class.
        /// </summary>
        public ExportDtoVariant1()
        {
        }
    }
}