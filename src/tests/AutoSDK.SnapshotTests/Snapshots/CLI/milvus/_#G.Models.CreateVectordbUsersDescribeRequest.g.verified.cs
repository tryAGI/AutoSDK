//HintName: G.Models.CreateVectordbUsersDescribeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbUsersDescribeRequest
    {
        /// <summary>
        ///   The name of the user to describe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbUsersDescribeRequest" /> class.
        /// </summary>
        /// <param name="userName">
        ///   The name of the user to describe.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVectordbUsersDescribeRequest(
            string userName)
        {
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbUsersDescribeRequest" /> class.
        /// </summary>
        public CreateVectordbUsersDescribeRequest()
        {
        }
    }
}