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
        [global::System.Text.Json.Serialization.JsonPropertyName("datetime_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatetimeKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeKeyExpression" /> class.
        /// </summary>
        /// <param name="datetimeKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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