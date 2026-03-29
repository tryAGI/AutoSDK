//HintName: G.Models.ExactReplacement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExactReplacement
    {
        /// <summary>
        /// This is the exact replacement type. You can use this to replace a specific word or phrase with a different word or phrase.<br/>
        /// Usage:<br/>
        /// - Replace "hello" with "hi": { type: 'exact', key: 'hello', value: 'hi' }<br/>
        /// - Replace "good morning" with "good day": { type: 'exact', key: 'good morning', value: 'good day' }<br/>
        /// - Replace a specific name: { type: 'exact', key: 'John Doe', value: 'Jane Smith' }<br/>
        /// - Replace an acronym: { type: 'exact', key: 'AI', value: 'Artificial Intelligence' }<br/>
        /// - Replace a company name with its phonetic pronunciation: { type: 'exact', key: 'Vapi', value: 'Vappy' }
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExactReplacementTypeJsonConverter))]
        public global::G.ExactReplacementType Type { get; set; }

        /// <summary>
        /// This option let's you control whether to replace all instances of the key or only the first one. By default, it only replaces the first instance.<br/>
        /// Examples:<br/>
        /// - For { type: 'exact', key: 'hello', value: 'hi', replaceAllEnabled: false }. Before: "hello world, hello universe" | After: "hi world, hello universe"<br/>
        /// - For { type: 'exact', key: 'hello', value: 'hi', replaceAllEnabled: true }. Before: "hello world, hello universe" | After: "hi world, hi universe"<br/>
        /// @default false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replaceAllEnabled")]
        public bool? ReplaceAllEnabled { get; set; }

        /// <summary>
        /// This is the key to replace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// This is the value that will replace the match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExactReplacement" /> class.
        /// </summary>
        /// <param name="key">
        /// This is the key to replace.
        /// </param>
        /// <param name="value">
        /// This is the value that will replace the match.
        /// </param>
        /// <param name="type">
        /// This is the exact replacement type. You can use this to replace a specific word or phrase with a different word or phrase.<br/>
        /// Usage:<br/>
        /// - Replace "hello" with "hi": { type: 'exact', key: 'hello', value: 'hi' }<br/>
        /// - Replace "good morning" with "good day": { type: 'exact', key: 'good morning', value: 'good day' }<br/>
        /// - Replace a specific name: { type: 'exact', key: 'John Doe', value: 'Jane Smith' }<br/>
        /// - Replace an acronym: { type: 'exact', key: 'AI', value: 'Artificial Intelligence' }<br/>
        /// - Replace a company name with its phonetic pronunciation: { type: 'exact', key: 'Vapi', value: 'Vappy' }
        /// </param>
        /// <param name="replaceAllEnabled">
        /// This option let's you control whether to replace all instances of the key or only the first one. By default, it only replaces the first instance.<br/>
        /// Examples:<br/>
        /// - For { type: 'exact', key: 'hello', value: 'hi', replaceAllEnabled: false }. Before: "hello world, hello universe" | After: "hi world, hello universe"<br/>
        /// - For { type: 'exact', key: 'hello', value: 'hi', replaceAllEnabled: true }. Before: "hello world, hello universe" | After: "hi world, hi universe"<br/>
        /// @default false<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExactReplacement(
            string key,
            string value,
            global::G.ExactReplacementType type,
            bool? replaceAllEnabled)
        {
            this.Type = type;
            this.ReplaceAllEnabled = replaceAllEnabled;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExactReplacement" /> class.
        /// </summary>
        public ExactReplacement()
        {
        }
    }
}