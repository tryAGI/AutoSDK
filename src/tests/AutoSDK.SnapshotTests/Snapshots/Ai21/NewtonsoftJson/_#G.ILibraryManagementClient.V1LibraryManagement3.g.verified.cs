//HintName: G.ILibraryManagementClient.V1LibraryManagement3.g.cs
#nullable enable

namespace G
{
    public partial interface ILibraryManagementClient
    {
        /// <summary>
        /// Update File<br/>
        /// Update the specified parameters of a specific document in the user's library.<br/>
        /// This operation currently supports updating the publicUrl and labels parameters.<br/>
        /// &gt; **This operation overwrites the specified items with the new data you provide.**<br/>
        /// &gt; If you wish to add new labels to the labels list without removing the existing ones,<br/>
        /// &gt; you must submit a labels list that includes both the current and new labels.**<br/>
        /// &gt;<br/>
        /// &gt; For instance, if the current labels are "Label A" and "Label B", and you wish to<br/>
        /// &gt; add "New Label C" and "New Label D" to the list, you must specify `"labels": ["Label A", "Label B", "New Label C", "New Label D"]`.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.V1LibraryManagementResponse> V1LibraryManagement3Async(
            global::System.Guid fileId,
            global::G.FilesUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update File<br/>
        /// Update the specified parameters of a specific document in the user's library.<br/>
        /// This operation currently supports updating the publicUrl and labels parameters.<br/>
        /// &gt; **This operation overwrites the specified items with the new data you provide.**<br/>
        /// &gt; If you wish to add new labels to the labels list without removing the existing ones,<br/>
        /// &gt; you must submit a labels list that includes both the current and new labels.**<br/>
        /// &gt;<br/>
        /// &gt; For instance, if the current labels are "Label A" and "Label B", and you wish to<br/>
        /// &gt; add "New Label C" and "New Label D" to the list, you must specify `"labels": ["Label A", "Label B", "New Label C", "New Label D"]`.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="publicUrl">
        /// The public URL of the file, if any. This URL is not validated by<br/>
        /// AI21 or used in any way. It is strictly a piece of metadata that you can<br/>
        /// optionally attach to a file.
        /// </param>
        /// <param name="labels">
        /// Any labels to associate with this file. Separate multiple labels with commas. If<br/>
        /// provided, will overwrite all existing labels.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.V1LibraryManagementResponse> V1LibraryManagement3Async(
            global::System.Guid fileId,
            string? publicUrl = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}