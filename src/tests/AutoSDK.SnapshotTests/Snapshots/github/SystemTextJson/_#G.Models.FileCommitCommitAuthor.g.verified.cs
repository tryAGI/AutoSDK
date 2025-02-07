//HintName: G.Models.FileCommitCommitAuthor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileCommitCommitAuthor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitCommitAuthor" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileCommitCommitAuthor(
            string? date,
            string? name,
            string? email)
        {
            this.Date = date;
            this.Name = name;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitCommitAuthor" /> class.
        /// </summary>
        public FileCommitCommitAuthor()
        {
        }
    }
}