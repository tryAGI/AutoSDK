//HintName: G.Models.PhoneNumberCallEndingHookFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberCallEndingHookFilter
    {
        /// <summary>
        /// This is the type of filter - currently only "oneOf" is supported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PhoneNumberCallEndingHookFilterTypeJsonConverter))]
        public global::G.PhoneNumberCallEndingHookFilterType Type { get; set; }

        /// <summary>
        /// This is the key to filter on - only "call.endedReason" is allowed for phone number call ending hooks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PhoneNumberCallEndingHookFilterKeyJsonConverter))]
        public global::G.PhoneNumberCallEndingHookFilterKey Key { get; set; }

        /// <summary>
        /// This is the array of assistant-request related ended reasons to match against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneOf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PhoneNumberCallEndingHookFilterOneOfItem> OneOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberCallEndingHookFilter" /> class.
        /// </summary>
        /// <param name="oneOf">
        /// This is the array of assistant-request related ended reasons to match against
        /// </param>
        /// <param name="type">
        /// This is the type of filter - currently only "oneOf" is supported
        /// </param>
        /// <param name="key">
        /// This is the key to filter on - only "call.endedReason" is allowed for phone number call ending hooks
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberCallEndingHookFilter(
            global::System.Collections.Generic.IList<global::G.PhoneNumberCallEndingHookFilterOneOfItem> oneOf,
            global::G.PhoneNumberCallEndingHookFilterType type,
            global::G.PhoneNumberCallEndingHookFilterKey key)
        {
            this.Type = type;
            this.Key = key;
            this.OneOf = oneOf ?? throw new global::System.ArgumentNullException(nameof(oneOf));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberCallEndingHookFilter" /> class.
        /// </summary>
        public PhoneNumberCallEndingHookFilter()
        {
        }
    }
}