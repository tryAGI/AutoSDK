//HintName: G.Models.BodyCreateV4FilesPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateV4FilesPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pfile")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Pfile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pfilename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pfilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateV4FilesPost" /> class.
        /// </summary>
        /// <param name="pfile"></param>
        /// <param name="pfilename"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyCreateV4FilesPost(
            byte[] pfile,
            string pfilename)
        {
            this.Pfile = pfile ?? throw new global::System.ArgumentNullException(nameof(pfile));
            this.Pfilename = pfilename ?? throw new global::System.ArgumentNullException(nameof(pfilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateV4FilesPost" /> class.
        /// </summary>
        public BodyCreateV4FilesPost()
        {
        }
    }
}