﻿//HintName: G.IPointersClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IPointersClient
    {
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="pointer"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string pointer,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}