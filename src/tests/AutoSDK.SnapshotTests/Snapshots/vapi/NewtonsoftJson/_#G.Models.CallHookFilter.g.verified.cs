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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CallHookFilterTypeJsonConverter))]
        public global::G.CallHookFilterType Type { get; set; }

        /// <summary>
        /// This is the key to filter on (e.g. "call.endedReason")
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// This is the array of possible values to match against
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oneOf", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> OneOf { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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