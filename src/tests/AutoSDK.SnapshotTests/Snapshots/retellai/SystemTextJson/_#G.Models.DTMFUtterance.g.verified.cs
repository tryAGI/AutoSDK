//HintName: G.Models.DTMFUtterance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DTMFUtterance
    {
        /// <summary>
        /// Digit pressed by the user from their phone keypad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DTMFUtteranceRoleJsonConverter))]
        public global::G.DTMFUtteranceRole Role { get; set; }

        /// <summary>
        /// The digit pressed by the user. Will be a single digit string like "1", "2", "3", "*", "#" etc.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("digit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DTMFUtterance" /> class.
        /// </summary>
        /// <param name="digit">
        /// The digit pressed by the user. Will be a single digit string like "1", "2", "3", "*", "#" etc.<br/>
        /// Example: 1
        /// </param>
        /// <param name="role">
        /// Digit pressed by the user from their phone keypad.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DTMFUtterance(
            string digit,
            global::G.DTMFUtteranceRole role)
        {
            this.Role = role;
            this.Digit = digit ?? throw new global::System.ArgumentNullException(nameof(digit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DTMFUtterance" /> class.
        /// </summary>
        public DTMFUtterance()
        {
        }
    }
}