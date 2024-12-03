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
        [global::Newtonsoft.Json.JsonProperty("pfile", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Pfile { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pfilename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pfilename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateV4FilesPost" /> class.
        /// </summary>
        /// <param name="pfile"></param>
        /// <param name="pfilename"></param>
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