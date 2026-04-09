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
        [global::Newtonsoft.Json.JsonProperty("pronunciationDictionaryId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PronunciationDictionaryId { get; set; } = default!;

        /// <summary>
        /// The name of the pronunciation dictionary<br/>
        /// Example: My Dictionary
        /// </summary>
        /// <example>My Dictionary</example>
        [global::Newtonsoft.Json.JsonProperty("dictionaryName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DictionaryName { get; set; } = default!;

        /// <summary>
        /// The user ID of the creator<br/>
        /// Example: ar6633Es2kUjFXBdR1iVc9ztsXl1
        /// </summary>
        /// <example>ar6633Es2kUjFXBdR1iVc9ztsXl1</example>
        [global::Newtonsoft.Json.JsonProperty("createdBy", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// The creation time in Unix timestamp<br/>
        /// Example: 1714156800
        /// </summary>
        /// <example>1714156800</example>
        [global::Newtonsoft.Json.JsonProperty("creationTimeUnix", Required = global::Newtonsoft.Json.Required.Always)]
        public double CreationTimeUnix { get; set; } = default!;

        /// <summary>
        /// The version ID of the pronunciation dictionary<br/>
        /// Example: 5xM3yVvZQKV0EfqQpLrJ
        /// </summary>
        /// <example>5xM3yVvZQKV0EfqQpLrJ</example>
        [global::Newtonsoft.Json.JsonProperty("versionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// The number of rules in this version<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("versionRulesNum", Required = global::Newtonsoft.Json.Required.Always)]
        public double VersionRulesNum { get; set; } = default!;

        /// <summary>
        /// The permission level on this resource
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissionOnResource")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ElevenLabsPronunciationDictionaryPermissionOnResourceJsonConverter))]
        public global::G.ElevenLabsPronunciationDictionaryPermissionOnResource? PermissionOnResource { get; set; }

        /// <summary>
        /// The description of the pronunciation dictionary<br/>
        /// Example: This is a test dictionary
        /// </summary>
        /// <example>This is a test dictionary</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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