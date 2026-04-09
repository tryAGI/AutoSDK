//HintName: G.Models.CheckAvailabilityCalTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckAvailabilityCalTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CheckAvailabilityCalToolTypeJsonConverter))]
        public global::G.CheckAvailabilityCalToolType Type { get; set; }

        /// <summary>
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state transitions). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Cal.com Api key that have access to the cal.com event you want to check availability for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cal_api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string CalApiKey { get; set; } = default!;

        /// <summary>
        /// Cal.com event type id number for the cal.com event you want to check availability for. Can be a number or a dynamic variable in the format `{{variable_name}}` that will be resolved at runtime.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<double?, string> EventTypeId { get; set; } = default!;

        /// <summary>
        /// Timezone to be used when checking availability, must be in [IANA timezone database](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). Can also be a dynamic variable in the format `{{variable_name}}` that will be resolved at runtime. If not specified, will check if user specified timezone in call, and if not, will use the timezone of the Retell servers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAvailabilityCalTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool. Must be unique within all tools available to LLM at any given time (general tools + state tools + state transitions). Must be consisted of a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64 (no space allowed).
        /// </param>
        /// <param name="calApiKey">
        /// Cal.com Api key that have access to the cal.com event you want to check availability for.
        /// </param>
        /// <param name="eventTypeId">
        /// Cal.com event type id number for the cal.com event you want to check availability for. Can be a number or a dynamic variable in the format `{{variable_name}}` that will be resolved at runtime.
        /// </param>
        /// <param name="type"></param>
        /// <param name="description">
        /// Describes what the tool does, sometimes can also include information about when to call the tool.
        /// </param>
        /// <param name="timezone">
        /// Timezone to be used when checking availability, must be in [IANA timezone database](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). Can also be a dynamic variable in the format `{{variable_name}}` that will be resolved at runtime. If not specified, will check if user specified timezone in call, and if not, will use the timezone of the Retell servers.
        /// </param>
        public CheckAvailabilityCalTool(
            string name,
            string calApiKey,
            global::G.OneOf<double?, string> eventTypeId,
            global::G.CheckAvailabilityCalToolType type,
            string? description,
            string? timezone)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.CalApiKey = calApiKey ?? throw new global::System.ArgumentNullException(nameof(calApiKey));
            this.EventTypeId = eventTypeId;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAvailabilityCalTool" /> class.
        /// </summary>
        public CheckAvailabilityCalTool()
        {
        }
    }
}