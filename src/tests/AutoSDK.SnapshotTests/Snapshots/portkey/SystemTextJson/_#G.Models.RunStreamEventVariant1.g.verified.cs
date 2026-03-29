//HintName: G.Models.RunStreamEventVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a new [run](https://platform.openai.com/docs/api-reference/runs/object) is created.
    /// </summary>
    public sealed partial class RunStreamEventVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStreamEventVariant1EventJsonConverter))]
        public global::G.RunStreamEventVariant1Event Event { get; set; }

        /// <summary>
        /// Represents an execution run on a [thread](https://platform.openai.com/docs/api-reference/threads).
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
        /// Initializes a new instance of the <see cref="RunStreamEventVariant1" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents an execution run on a [thread](https://platform.openai.com/docs/api-reference/threads).
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStreamEventVariant1(
            global::G.RunObject data,
            global::G.RunStreamEventVariant1Event @event)
        {
            this.Event = @event;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStreamEventVariant1" /> class.
        /// </summary>
        public RunStreamEventVariant1()
        {
        }
    }
}