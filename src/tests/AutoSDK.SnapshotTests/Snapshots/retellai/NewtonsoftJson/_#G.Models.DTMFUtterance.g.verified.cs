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
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.DTMFUtteranceRole Role { get; set; }

        /// <summary>
        /// The digit pressed by the user. Will be a single digit string like "1", "2", "3", "*", "#" etc.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("digit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Digit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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