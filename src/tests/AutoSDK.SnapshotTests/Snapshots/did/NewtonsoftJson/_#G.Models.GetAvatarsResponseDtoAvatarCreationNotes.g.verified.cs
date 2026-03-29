//HintName: G.Models.GetAvatarsResponseDtoAvatarCreationNotes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// a creation notes for the avatar
    /// </summary>
    public sealed partial class GetAvatarsResponseDtoAvatarCreationNotes
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
        public global::System.Collections.Generic.IList<global::G.GetAvatarsResponseDtoAvatarCreationNotesWorkerError>? WorkerErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponseDtoAvatarCreationNotes" /> class.
        /// </summary>
        /// <param name="isCloneVoiceFailed"></param>
        /// <param name="workerErrors"></param>
        public GetAvatarsResponseDtoAvatarCreationNotes(
            bool? isCloneVoiceFailed,
            global::System.Collections.Generic.IList<global::G.GetAvatarsResponseDtoAvatarCreationNotesWorkerError>? workerErrors)
        {
            this.IsCloneVoiceFailed = isCloneVoiceFailed;
            this.WorkerErrors = workerErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponseDtoAvatarCreationNotes" /> class.
        /// </summary>
        public GetAvatarsResponseDtoAvatarCreationNotes()
        {
        }
    }
}