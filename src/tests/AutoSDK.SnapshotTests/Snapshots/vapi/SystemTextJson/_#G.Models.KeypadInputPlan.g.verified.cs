//HintName: G.Models.KeypadInputPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeypadInputPlan
    {
        /// <summary>
        /// This keeps track of whether the user has enabled keypad input.<br/>
        /// By default, it is off.<br/>
        /// @default false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This is the time in seconds to wait before processing the input.<br/>
        /// If the input is not received within this time, the input will be ignored.<br/>
        /// If set to "off", the input will be processed when the user enters a delimiter or immediately if no delimiter is used.<br/>
        /// @default 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// This is the delimiter(s) that will be used to process the input.<br/>
        /// Can be '#', '*', or an empty array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delimiters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.KeypadInputPlanDelimitersJsonConverter))]
        public global::G.KeypadInputPlanDelimiters? Delimiters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeypadInputPlan" /> class.
        /// </summary>
        /// <param name="enabled">
        /// This keeps track of whether the user has enabled keypad input.<br/>
        /// By default, it is off.<br/>
        /// @default false
        /// </param>
        /// <param name="timeoutSeconds">
        /// This is the time in seconds to wait before processing the input.<br/>
        /// If the input is not received within this time, the input will be ignored.<br/>
        /// If set to "off", the input will be processed when the user enters a delimiter or immediately if no delimiter is used.<br/>
        /// @default 2
        /// </param>
        /// <param name="delimiters">
        /// This is the delimiter(s) that will be used to process the input.<br/>
        /// Can be '#', '*', or an empty array.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeypadInputPlan(
            bool? enabled,
            double? timeoutSeconds,
            global::G.KeypadInputPlanDelimiters? delimiters)
        {
            this.Enabled = enabled;
            this.TimeoutSeconds = timeoutSeconds;
            this.Delimiters = delimiters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeypadInputPlan" /> class.
        /// </summary>
        public KeypadInputPlan()
        {
        }
    }
}