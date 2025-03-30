//HintName: G.Models.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost
    {
        /// <summary>
        /// List of pronunciation rules. Rule can be either:<br/>
        ///     an alias rule: {'string_to_replace': 'a', 'type': 'alias', 'alias': 'b', }<br/>
        ///     or a phoneme rule: {'string_to_replace': 'a', 'type': 'phoneme', 'phoneme': 'b', 'alphabet': 'ipa' }<br/>
        /// Example: <br/>
        ///     [<br/>
        ///         {'string_to_replace': 'a', 'type': 'alias', 'alias': 'b' },<br/>
        ///         {'string_to_replace': 'c', 'type': 'phoneme', 'phoneme': 'd', 'alphabet': 'ipa' }<br/>
        ///     ]
        /// </summary>
        /// <example>
        ///     [<br/>
        ///         {'string_to_replace': 'a', 'type': 'alias', 'alias': 'b' },<br/>
        ///         {'string_to_replace': 'c', 'type': 'phoneme', 'phoneme': 'd', 'alphabet': 'ipa' }<br/>
        ///     ]
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>> Rules { get; set; }

        /// <summary>
        /// The name of the pronunciation dictionary, used for identification only.<br/>
        /// Example: My Dictionary
        /// </summary>
        /// <example>My Dictionary</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the pronunciation dictionary, used for identification only.<br/>
        /// Example: Contains pronunciation's of our character names
        /// </summary>
        /// <example>Contains pronunciation's of our character names</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Should be one of 'admin', 'editor' or 'viewer'. If not provided, defaults to no access.<br/>
        /// Example: viewer
        /// </summary>
        /// <example>viewer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccessJsonConverter))]
        public global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess? WorkspaceAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost" /> class.
        /// </summary>
        /// <param name="rules">
        /// List of pronunciation rules. Rule can be either:<br/>
        ///     an alias rule: {'string_to_replace': 'a', 'type': 'alias', 'alias': 'b', }<br/>
        ///     or a phoneme rule: {'string_to_replace': 'a', 'type': 'phoneme', 'phoneme': 'b', 'alphabet': 'ipa' }<br/>
        /// Example: <br/>
        ///     [<br/>
        ///         {'string_to_replace': 'a', 'type': 'alias', 'alias': 'b' },<br/>
        ///         {'string_to_replace': 'c', 'type': 'phoneme', 'phoneme': 'd', 'alphabet': 'ipa' }<br/>
        ///     ]
        /// </param>
        /// <param name="name">
        /// The name of the pronunciation dictionary, used for identification only.<br/>
        /// Example: My Dictionary
        /// </param>
        /// <param name="description">
        /// A description of the pronunciation dictionary, used for identification only.<br/>
        /// Example: Contains pronunciation's of our character names
        /// </param>
        /// <param name="workspaceAccess">
        /// Should be one of 'admin', 'editor' or 'viewer'. If not provided, defaults to no access.<br/>
        /// Example: viewer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost(
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.PronunciationDictionaryAliasRuleRequestModel, global::G.PronunciationDictionaryPhonemeRuleRequestModel>> rules,
            string name,
            string? description,
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess? workspaceAccess)
        {
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.WorkspaceAccess = workspaceAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost" /> class.
        /// </summary>
        public BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost()
        {
        }
    }
}