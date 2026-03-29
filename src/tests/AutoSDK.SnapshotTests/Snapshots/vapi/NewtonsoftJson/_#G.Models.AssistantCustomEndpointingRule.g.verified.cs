//HintName: G.Models.AssistantCustomEndpointingRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantCustomEndpointingRule
    {
        /// <summary>
        /// This endpointing rule is based on the last assistant message before customer started speaking.<br/>
        /// Flow:<br/>
        /// - Assistant speaks<br/>
        /// - Customer starts speaking<br/>
        /// - Customer transcription comes in<br/>
        /// - This rule is evaluated on the last assistant message<br/>
        /// - If a match is found based on `regex`, the endpointing timeout is set to `timeoutSeconds`<br/>
        /// Usage:<br/>
        /// - If you have yes/no questions in your use case like "are you interested in a loan?", you can set a shorter timeout.<br/>
        /// - If you have questions where the customer may pause to look up information like "what's my account number?", you can set a longer timeout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AssistantCustomEndpointingRuleType Type { get; set; }

        /// <summary>
        /// This is the regex pattern to match.<br/>
        /// Note:<br/>
        /// - This works by using the `RegExp.test` method in Node.JS. Eg. `/hello/.test("hello there")` will return `true`.<br/>
        /// Hot tip:<br/>
        /// - In JavaScript, escape `\` when sending the regex pattern. Eg. `"hello\sthere"` will be sent over the wire as `"hellosthere"`. Send `"hello\\sthere"` instead.<br/>
        /// - `RegExp.test` does substring matching, so `/cat/.test("I love cats")` will return `true`. To do full string matching, send "^cat$".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regex", Required = global::Newtonsoft.Json.Required.Always)]
        public string Regex { get; set; } = default!;

        /// <summary>
        /// These are the options for the regex match. Defaults to all disabled.<br/>
        /// @default []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regexOptions")]
        public global::System.Collections.Generic.IList<global::G.RegexOption>? RegexOptions { get; set; }

        /// <summary>
        /// This is the endpointing timeout in seconds, if the rule is matched.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeoutSeconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double TimeoutSeconds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantCustomEndpointingRule" /> class.
        /// </summary>
        /// <param name="regex">
        /// This is the regex pattern to match.<br/>
        /// Note:<br/>
        /// - This works by using the `RegExp.test` method in Node.JS. Eg. `/hello/.test("hello there")` will return `true`.<br/>
        /// Hot tip:<br/>
        /// - In JavaScript, escape `\` when sending the regex pattern. Eg. `"hello\sthere"` will be sent over the wire as `"hellosthere"`. Send `"hello\\sthere"` instead.<br/>
        /// - `RegExp.test` does substring matching, so `/cat/.test("I love cats")` will return `true`. To do full string matching, send "^cat$".
        /// </param>
        /// <param name="timeoutSeconds">
        /// This is the endpointing timeout in seconds, if the rule is matched.
        /// </param>
        /// <param name="type">
        /// This endpointing rule is based on the last assistant message before customer started speaking.<br/>
        /// Flow:<br/>
        /// - Assistant speaks<br/>
        /// - Customer starts speaking<br/>
        /// - Customer transcription comes in<br/>
        /// - This rule is evaluated on the last assistant message<br/>
        /// - If a match is found based on `regex`, the endpointing timeout is set to `timeoutSeconds`<br/>
        /// Usage:<br/>
        /// - If you have yes/no questions in your use case like "are you interested in a loan?", you can set a shorter timeout.<br/>
        /// - If you have questions where the customer may pause to look up information like "what's my account number?", you can set a longer timeout.
        /// </param>
        /// <param name="regexOptions">
        /// These are the options for the regex match. Defaults to all disabled.<br/>
        /// @default []
        /// </param>
        public AssistantCustomEndpointingRule(
            string regex,
            double timeoutSeconds,
            global::G.AssistantCustomEndpointingRuleType type,
            global::System.Collections.Generic.IList<global::G.RegexOption>? regexOptions)
        {
            this.Type = type;
            this.Regex = regex ?? throw new global::System.ArgumentNullException(nameof(regex));
            this.RegexOptions = regexOptions;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantCustomEndpointingRule" /> class.
        /// </summary>
        public AssistantCustomEndpointingRule()
        {
        }
    }
}