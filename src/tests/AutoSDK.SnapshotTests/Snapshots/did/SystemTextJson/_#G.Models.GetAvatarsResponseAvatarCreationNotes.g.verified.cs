//HintName: G.Models.GetAvatarsResponseAvatarCreationNotes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// a creation notes for the avatar
    /// </summary>
    public sealed partial class GetAvatarsResponseAvatarCreationNotes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_clone_voice_failed")]
        public bool? IsCloneVoiceFailed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("worker_errors")]
        public global::System.Collections.Generic.IList<global::G.GetAvatarsResponseAvatarCreationNotesWorkerError>? WorkerErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponseAvatarCreationNotes" /> class.
        /// </summary>
        /// <param name="isCloneVoiceFailed"></param>
        /// <param name="workerErrors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarsResponseAvatarCreationNotes(
            bool? isCloneVoiceFailed,
            global::System.Collections.Generic.IList<global::G.GetAvatarsResponseAvatarCreationNotesWorkerError>? workerErrors)
        {
            this.IsCloneVoiceFailed = isCloneVoiceFailed;
            this.WorkerErrors = workerErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponseAvatarCreationNotes" /> class.
        /// </summary>
        public GetAvatarsResponseAvatarCreationNotes()
        {
        }
    }
}