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
        [global::Newtonsoft.Json.JsonProperty("userName", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbUsersDescribeRequest" /> class.
        /// </summary>
        /// <param name="userName">
        ///   The name of the user to describe.
        /// </param>
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