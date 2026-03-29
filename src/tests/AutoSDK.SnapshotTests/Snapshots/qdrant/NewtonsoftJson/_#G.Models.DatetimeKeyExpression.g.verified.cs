//HintName: G.Models.DatetimeKeyExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatetimeKeyExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datetime_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatetimeKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeKeyExpression" /> class.
        /// </summary>
        /// <param name="datetimeKey"></param>
        public DatetimeKeyExpression(
            string datetimeKey)
        {
            this.DatetimeKey = datetimeKey ?? throw new global::System.ArgumentNullException(nameof(datetimeKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeKeyExpression" /> class.
        /// </summary>
        public DatetimeKeyExpression()
        {
        }
    }
}