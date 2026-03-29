//HintName: G.Models.SayPhoneNumberHookAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SayPhoneNumberHookAction
    {
        /// <summary>
        /// This is the type of action - must be "say"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SayPhoneNumberHookActionTypeJsonConverter))]
        public global::G.SayPhoneNumberHookActionType Type { get; set; }

        /// <summary>
        /// This is the message to say
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exact")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Exact { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SayPhoneNumberHookAction" /> class.
        /// </summary>
        /// <param name="exact">
        /// This is the message to say
        /// </param>
        /// <param name="type">
        /// This is the type of action - must be "say"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SayPhoneNumberHookAction(
            string exact,
            global::G.SayPhoneNumberHookActionType type)
        {
            this.Type = type;
            this.Exact = exact ?? throw new global::System.ArgumentNullException(nameof(exact));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SayPhoneNumberHookAction" /> class.
        /// </summary>
        public SayPhoneNumberHookAction()
        {
        }
    }
}