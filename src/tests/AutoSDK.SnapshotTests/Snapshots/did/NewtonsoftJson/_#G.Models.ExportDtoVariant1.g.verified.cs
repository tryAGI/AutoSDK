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
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The start of the time range for the export.  If not provided, the export will start from the beginning of the agent's data<br/>
        /// Example: 2024-05-15T12:00:00Z
        /// </summary>
        /// <example>2024-05-15T12:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public string? From { get; set; }

        /// <summary>
        /// The end of the time range for the export. If not provided, the export will run until the current time<br/>
        /// Example: 2024-05-15T12:00:00Z
        /// </summary>
        /// <example>2024-05-15T12:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("to")]
        public string? To { get; set; }

        /// <summary>
        /// Determines if the export should fetch persistent chats. Defaults to true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("persistent_chats")]
        public bool? PersistentChats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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