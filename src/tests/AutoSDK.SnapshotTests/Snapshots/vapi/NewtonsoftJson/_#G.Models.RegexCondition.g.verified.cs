//HintName: G.Models.RegexCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegexCondition
    {
        /// <summary>
        /// This is the type discriminator for regex condition<br/>
        /// Example: regex
        /// </summary>
        /// <example>regex</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RegexConditionTypeJsonConverter))]
        public global::G.RegexConditionType Type { get; set; }

        /// <summary>
        /// This is the regular expression pattern to match against message content.<br/>
        /// Note:<br/>
        /// - This works by using the RegExp.test method in Node.JS. Eg. /hello/.test("hello there") will return true.<br/>
        /// Hot tips:<br/>
        /// - In JavaScript, escape \ when sending the regex pattern. Eg. "hello\sthere" will be sent over the wire as "hellosthere". Send "hello\\sthere" instead.<br/>
        /// - RegExp.test does substring matching, so /cat/.test("I love cats") will return true. To do full string matching, use anchors: /^cat$/ will only match exactly "cat".<br/>
        /// - Word boundaries \b are useful for matching whole words: /\bcat\b/ matches "cat" but not "cats" or "category".<br/>
        /// - Use inline flags for portability: (?i) for case insensitive, (?m) for multiline
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regex", Required = global::Newtonsoft.Json.Required.Always)]
        public string Regex { get; set; } = default!;

        /// <summary>
        /// This is the target for messages to check against.<br/>
        /// If not specified, the condition will run on the last message (position: -1).<br/>
        /// If role is not specified, it will look at the last message regardless of role.<br/>
        /// @default { position: -1 }
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public global::G.MessageTarget? Target { get; set; }

        /// <summary>
        /// This is the flag that when true, the condition matches if the pattern does NOT match.<br/>
        /// Useful for ensuring certain words/phrases are absent.<br/>
        /// @default false<br/>
        /// Example: true - Reject if user hasn"t said goodbye: { regex: "\\b(bye|goodbye)\\b", negate: true }
        /// </summary>
        /// <example>true - Reject if user hasn"t said goodbye: { regex: "\\b(bye|goodbye)\\b", negate: true }</example>
        [global::Newtonsoft.Json.JsonProperty("negate")]
        public bool? Negate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexCondition" /> class.
        /// </summary>
        /// <param name="regex">
        /// This is the regular expression pattern to match against message content.<br/>
        /// Note:<br/>
        /// - This works by using the RegExp.test method in Node.JS. Eg. /hello/.test("hello there") will return true.<br/>
        /// Hot tips:<br/>
        /// - In JavaScript, escape \ when sending the regex pattern. Eg. "hello\sthere" will be sent over the wire as "hellosthere". Send "hello\\sthere" instead.<br/>
        /// - RegExp.test does substring matching, so /cat/.test("I love cats") will return true. To do full string matching, use anchors: /^cat$/ will only match exactly "cat".<br/>
        /// - Word boundaries \b are useful for matching whole words: /\bcat\b/ matches "cat" but not "cats" or "category".<br/>
        /// - Use inline flags for portability: (?i) for case insensitive, (?m) for multiline
        /// </param>
        /// <param name="type">
        /// This is the type discriminator for regex condition<br/>
        /// Example: regex
        /// </param>
        /// <param name="target">
        /// This is the target for messages to check against.<br/>
        /// If not specified, the condition will run on the last message (position: -1).<br/>
        /// If role is not specified, it will look at the last message regardless of role.<br/>
        /// @default { position: -1 }
        /// </param>
        /// <param name="negate">
        /// This is the flag that when true, the condition matches if the pattern does NOT match.<br/>
        /// Useful for ensuring certain words/phrases are absent.<br/>
        /// @default false<br/>
        /// Example: true - Reject if user hasn"t said goodbye: { regex: "\\b(bye|goodbye)\\b", negate: true }
        /// </param>
        public RegexCondition(
            string regex,
            global::G.RegexConditionType type,
            global::G.MessageTarget? target,
            bool? negate)
        {
            this.Type = type;
            this.Regex = regex ?? throw new global::System.ArgumentNullException(nameof(regex));
            this.Target = target;
            this.Negate = negate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexCondition" /> class.
        /// </summary>
        public RegexCondition()
        {
        }
    }
}