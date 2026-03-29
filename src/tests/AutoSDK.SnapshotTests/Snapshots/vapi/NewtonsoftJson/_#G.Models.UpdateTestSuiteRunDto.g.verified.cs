//HintName: G.Models.UpdateTestSuiteRunDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTestSuiteRunDto
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
        /// Initializes a new instance of the <see cref="UpdateTestSuiteRunDto" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the test suite run.
        /// </param>
        public UpdateTestSuiteRunDto(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTestSuiteRunDto" /> class.
        /// </summary>
        public UpdateTestSuiteRunDto()
        {
        }
    }
}