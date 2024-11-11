//HintName: G.Models.DescribeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response for a describe request encapsulates a list of descriptions
    /// </summary>
    public sealed partial class DescribeResponse
    {
        /// <summary>
        /// A collection of descriptions for given content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptions")]
        public global::System.Collections.Generic.IList<global::G.Description>? Descriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeResponse" /> class.
        /// </summary>
        /// <param name="descriptions">
        /// A collection of descriptions for given content
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DescribeResponse(
            global::System.Collections.Generic.IList<global::G.Description>? descriptions)
        {
            this.Descriptions = descriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeResponse" /> class.
        /// </summary>
        public DescribeResponse()
        {
        }
    }
}