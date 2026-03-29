//HintName: G.Models.UserName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserName
    {
        /// <summary>
        /// The name of the target user. The value should start with a letter and can only contain underline, letters and numbers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userName", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName1 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserName" /> class.
        /// </summary>
        /// <param name="userName1">
        /// The name of the target user. The value should start with a letter and can only contain underline, letters and numbers.
        /// </param>
        public UserName(
            string userName1)
        {
            this.UserName1 = userName1 ?? throw new global::System.ArgumentNullException(nameof(userName1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserName" /> class.
        /// </summary>
        public UserName()
        {
        }
    }
}