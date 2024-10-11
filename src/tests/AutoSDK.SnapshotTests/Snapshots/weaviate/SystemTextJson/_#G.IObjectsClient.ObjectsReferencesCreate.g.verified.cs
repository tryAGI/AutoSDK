//HintName: G.IObjectsClient.ObjectsReferencesCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Add a cross-reference.<br/>
        /// Add a cross-reference.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="propertyName"></param>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.ErrorResponse> ObjectsReferencesCreateAsync(
            global::System.Guid id,
            string propertyName,
            global::G.SingleRef request,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a cross-reference.<br/>
        /// Add a cross-reference.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="propertyName"></param>
        /// <param name="tenant"></param>
        /// <param name="class">
        /// If using a concept reference (rather than a direct reference), specify the desired class name here
        /// </param>
        /// <param name="schema">
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </param>
        /// <param name="beacon">
        /// If using a direct reference, specify the URI to point to the cross-ref here. Should be in the form of weaviate://localhost/&lt;uuid&gt; for the example of a local cross-ref to an object
        /// </param>
        /// <param name="href">
        /// If using a direct reference, this read-only fields provides a link to the referenced resource. If 'origin' is globally configured, an absolute URI is shown - a relative URI otherwise.
        /// </param>
        /// <param name="classification">
        /// This meta field contains additional info about the classified reference property
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.ErrorResponse> ObjectsReferencesCreateAsync(
            global::System.Guid id,
            string propertyName,
            string? tenant = default,
            string? @class = default,
            object? schema = default,
            string? beacon = default,
            string? href = default,
            global::G.ReferenceMetaClassification? classification = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}