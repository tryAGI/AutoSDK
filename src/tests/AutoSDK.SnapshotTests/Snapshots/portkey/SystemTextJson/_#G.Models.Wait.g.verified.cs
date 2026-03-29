//HintName: G.Models.Wait.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A wait action.
    /// </summary>
    public sealed partial class Wait
    {
        /// <summary>
        /// Specifies the event type. For a wait action, this property is <br/>
        /// always set to `wait`.<br/>
        /// Default Value: wait
        /// </summary>
        /// <default>global::G.WaitType.Wait</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WaitTypeJsonConverter))]
        public global::G.WaitType Type { get; set; } = global::G.WaitType.Wait;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Wait" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a wait action, this property is <br/>
        /// always set to `wait`.<br/>
        /// Default Value: wait
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Wait(
            global::G.WaitType type = global::G.WaitType.Wait)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wait" /> class.
        /// </summary>
        public Wait()
        {
        }
    }
}