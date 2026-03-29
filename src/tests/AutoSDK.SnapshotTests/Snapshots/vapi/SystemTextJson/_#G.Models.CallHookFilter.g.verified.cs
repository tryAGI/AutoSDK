//HintName: G.Models.CallHookFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallHookFilter
    {
        /// <summary>
        /// This is the type of filter - currently only "oneOf" is supported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CallHookFilterTypeJsonConverter))]
        public global::G.CallHookFilterType Type { get; set; }

        /// <summary>
        /// This is the key to filter on (e.g. "call.endedReason")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// This is the array of possible values to match against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneOf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OneOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookFilter" /> class.
        /// </summary>
        /// <param name="key">
        /// This is the key to filter on (e.g. "call.endedReason")
        /// </param>
        /// <param name="oneOf">
        /// This is the array of possible values to match against
        /// </param>
        /// <param name="type">
        /// This is the type of filter - currently only "oneOf" is supported
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHookFilter(
            string key,
            global::System.Collections.Generic.IList<string> oneOf,
            global::G.CallHookFilterType type)
        {
            this.Type = type;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.OneOf = oneOf ?? throw new global::System.ArgumentNullException(nameof(oneOf));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookFilter" /> class.
        /// </summary>
        public CallHookFilter()
        {
        }
    }
}