//HintName: G.Models.GetResponseCreationNotes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// a creation notes for the avatar
    /// </summary>
    public sealed partial class GetResponseCreationNotes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_clone_voice_failed")]
        public bool? IsCloneVoiceFailed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("worker_errors")]
        public global::System.Collections.Generic.IList<global::G.GetResponseCreationNotesWorkerError>? WorkerErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResponseCreationNotes" /> class.
        /// </summary>
        /// <param name="isCloneVoiceFailed"></param>
        /// <param name="workerErrors"></param>
        public GetResponseCreationNotes(
            bool? isCloneVoiceFailed,
            global::System.Collections.Generic.IList<global::G.GetResponseCreationNotesWorkerError>? workerErrors)
        {
            this.IsCloneVoiceFailed = isCloneVoiceFailed;
            this.WorkerErrors = workerErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResponseCreationNotes" /> class.
        /// </summary>
        public GetResponseCreationNotes()
        {
        }
    }
}