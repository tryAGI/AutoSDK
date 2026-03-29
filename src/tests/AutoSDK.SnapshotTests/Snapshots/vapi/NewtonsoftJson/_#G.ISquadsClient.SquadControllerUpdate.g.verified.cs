//HintName: G.ISquadsClient.SquadControllerUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface ISquadsClient
    {
        /// <summary>
        /// Update Squad
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Squad> SquadControllerUpdateAsync(
            string id,

            global::G.UpdateSquadDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Squad
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// This is the name of the squad.
        /// </param>
        /// <param name="members">
        /// This is the list of assistants that make up the squad.<br/>
        /// The call will start with the first assistant in the list.
        /// </param>
        /// <param name="membersOverrides">
        /// This can be used to override all the assistants' settings and provide values for their template variables.<br/>
        /// Both `membersOverrides` and `members[n].assistantOverrides` can be used together. First, `members[n].assistantOverrides` is applied. Then, `membersOverrides` is applied as a global override.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Squad> SquadControllerUpdateAsync(
            string id,
            global::System.Collections.Generic.IList<global::G.SquadMemberDTO> members,
            string? name = default,
            global::G.AssistantOverrides? membersOverrides = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}