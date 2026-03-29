//HintName: G.Models.CreateTestSuiteRunDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTestSuiteRunDto
    {
        /// <summary>
        /// This is the name of the test suite run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTestSuiteRunDto" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the test suite run.
        /// </param>
        public CreateTestSuiteRunDto(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTestSuiteRunDto" /> class.
        /// </summary>
        public CreateTestSuiteRunDto()
        {
        }
    }
}