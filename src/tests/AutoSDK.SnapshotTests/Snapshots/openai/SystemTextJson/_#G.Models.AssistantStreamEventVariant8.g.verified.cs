﻿//HintName: G.Models.AssistantStreamEventVariant8.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a [run](/docs/api-reference/runs/object) is completed.
    /// </summary>
    public sealed partial class AssistantStreamEventVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantStreamEventVariant8EventJsonConverter))]
        public global::G.AssistantStreamEventVariant8Event Event { get; set; }

        /// <summary>
        /// Represents an execution run on a [thread](/docs/api-reference/threads).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RunObject Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant8" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data">
        /// Represents an execution run on a [thread](/docs/api-reference/threads).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantStreamEventVariant8(
            global::G.RunObject data,
            global::G.AssistantStreamEventVariant8Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantStreamEventVariant8" /> class.
        /// </summary>
        public AssistantStreamEventVariant8()
        {
        }
    }
}