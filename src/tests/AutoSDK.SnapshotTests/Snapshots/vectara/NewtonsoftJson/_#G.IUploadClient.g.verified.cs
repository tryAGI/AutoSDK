﻿//HintName: G.IUploadClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Upload files to a corpus for automatic parsing, text extraction, chunking, and indexing<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IUploadClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}