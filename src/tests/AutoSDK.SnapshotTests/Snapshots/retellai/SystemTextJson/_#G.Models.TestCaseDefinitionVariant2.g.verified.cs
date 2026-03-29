//HintName: G.Models.TestCaseDefinitionVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestCaseDefinitionVariant2
    {
        /// <summary>
        /// Unique identifier for the test case definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_definition_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestCaseDefinitionId { get; set; }

        /// <summary>
        /// Type of test case definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TestCaseDefinitionVariant2TypeJsonConverter))]
        public global::G.TestCaseDefinitionVariant2Type Type { get; set; }

        /// <summary>
        /// Timestamp when the test case definition was created (milliseconds since epoch)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long CreationTimestamp { get; set; }

        /// <summary>
        /// Timestamp when the test case definition was last modified (milliseconds since epoch)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_modified_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserModifiedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseDefinitionVariant2" /> class.
        /// </summary>
        /// <param name="testCaseDefinitionId">
        /// Unique identifier for the test case definition
        /// </param>
        /// <param name="creationTimestamp">
        /// Timestamp when the test case definition was created (milliseconds since epoch)
        /// </param>
        /// <param name="userModifiedTimestamp">
        /// Timestamp when the test case definition was last modified (milliseconds since epoch)
        /// </param>
        /// <param name="type">
        /// Type of test case definition
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseDefinitionVariant2(
            string testCaseDefinitionId,
            long creationTimestamp,
            long userModifiedTimestamp,
            global::G.TestCaseDefinitionVariant2Type type)
        {
            this.TestCaseDefinitionId = testCaseDefinitionId ?? throw new global::System.ArgumentNullException(nameof(testCaseDefinitionId));
            this.Type = type;
            this.CreationTimestamp = creationTimestamp;
            this.UserModifiedTimestamp = userModifiedTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseDefinitionVariant2" /> class.
        /// </summary>
        public TestCaseDefinitionVariant2()
        {
        }
    }
}