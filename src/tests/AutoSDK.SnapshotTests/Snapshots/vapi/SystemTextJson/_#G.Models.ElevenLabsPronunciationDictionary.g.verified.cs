//HintName: G.Models.ElevenLabsPronunciationDictionary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ElevenLabsPronunciationDictionary
    {
        /// <summary>
        /// The ID of the pronunciation dictionary<br/>
        /// Example: 5xM3yVvZQKV0EfqQpLrJ
        /// </summary>
        /// <example>5xM3yVvZQKV0EfqQpLrJ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciationDictionaryId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PronunciationDictionaryId { get; set; }

        /// <summary>
        /// The name of the pronunciation dictionary<br/>
        /// Example: My Dictionary
        /// </summary>
        /// <example>My Dictionary</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dictionaryName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DictionaryName { get; set; }

        /// <summary>
        /// The user ID of the creator<br/>
        /// Example: ar6633Es2kUjFXBdR1iVc9ztsXl1
        /// </summary>
        /// <example>ar6633Es2kUjFXBdR1iVc9ztsXl1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// The creation time in Unix timestamp<br/>
        /// Example: 1714156800
        /// </summary>
        /// <example>1714156800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationTimeUnix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreationTimeUnix { get; set; }

        /// <summary>
        /// The version ID of the pronunciation dictionary<br/>
        /// Example: 5xM3yVvZQKV0EfqQpLrJ
        /// </summary>
        /// <example>5xM3yVvZQKV0EfqQpLrJ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// The number of rules in this version<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionRulesNum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double VersionRulesNum { get; set; }

        /// <summary>
        /// The permission level on this resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissionOnResource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ElevenLabsPronunciationDictionaryPermissionOnResourceJsonConverter))]
        public global::G.ElevenLabsPronunciationDictionaryPermissionOnResource? PermissionOnResource { get; set; }

        /// <summary>
        /// The description of the pronunciation dictionary<br/>
        /// Example: This is a test dictionary
        /// </summary>
        /// <example>This is a test dictionary</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsPronunciationDictionary" /> class.
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The ID of the pronunciation dictionary<br/>
        /// Example: 5xM3yVvZQKV0EfqQpLrJ
        /// </param>
        /// <param name="dictionaryName">
        /// The name of the pronunciation dictionary<br/>
        /// Example: My Dictionary
        /// </param>
        /// <param name="createdBy">
        /// The user ID of the creator<br/>
        /// Example: ar6633Es2kUjFXBdR1iVc9ztsXl1
        /// </param>
        /// <param name="creationTimeUnix">
        /// The creation time in Unix timestamp<br/>
        /// Example: 1714156800
        /// </param>
        /// <param name="versionId">
        /// The version ID of the pronunciation dictionary<br/>
        /// Example: 5xM3yVvZQKV0EfqQpLrJ
        /// </param>
        /// <param name="versionRulesNum">
        /// The number of rules in this version<br/>
        /// Example: 5
        /// </param>
        /// <param name="permissionOnResource">
        /// The permission level on this resource
        /// </param>
        /// <param name="description">
        /// The description of the pronunciation dictionary<br/>
        /// Example: This is a test dictionary
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsPronunciationDictionary(
            string pronunciationDictionaryId,
            string dictionaryName,
            string createdBy,
            double creationTimeUnix,
            string versionId,
            double versionRulesNum,
            global::G.ElevenLabsPronunciationDictionaryPermissionOnResource? permissionOnResource,
            string? description)
        {
            this.PronunciationDictionaryId = pronunciationDictionaryId ?? throw new global::System.ArgumentNullException(nameof(pronunciationDictionaryId));
            this.DictionaryName = dictionaryName ?? throw new global::System.ArgumentNullException(nameof(dictionaryName));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreationTimeUnix = creationTimeUnix;
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.VersionRulesNum = versionRulesNum;
            this.PermissionOnResource = permissionOnResource;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsPronunciationDictionary" /> class.
        /// </summary>
        public ElevenLabsPronunciationDictionary()
        {
        }
    }
}