//HintName: G.Models.DatetimeServerToolParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatetimeServerToolParameters
    {
        /// <summary>
        /// IANA timezone name (e.g. "America/New_York"). Defaults to UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeServerToolParameters" /> class.
        /// </summary>
        /// <param name="timezone">
        /// IANA timezone name (e.g. "America/New_York"). Defaults to UTC.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatetimeServerToolParameters(
            string? timezone)
        {
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatetimeServerToolParameters" /> class.
        /// </summary>
        public DatetimeServerToolParameters()
        {
        }
    }
}