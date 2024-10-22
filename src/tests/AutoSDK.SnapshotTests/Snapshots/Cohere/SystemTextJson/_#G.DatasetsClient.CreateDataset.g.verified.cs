//HintName: G.DatasetsClient.CreateDataset.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareCreateDatasetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string name,
            ref global::G.DatasetType type,
            ref bool? keepOriginalFile,
            ref bool? skipMalformedInput,
            global::System.Collections.Generic.IList<string>? keepFields,
            global::System.Collections.Generic.IList<string>? optionalFields,
            ref string? textSeparator,
            ref string? csvDelimiter,
            ref string? xClientName,
            global::G.CreateDatasetRequest request);
        partial void PrepareCreateDatasetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string name,
            global::G.DatasetType type,
            bool? keepOriginalFile,
            bool? skipMalformedInput,
            global::System.Collections.Generic.IList<string>? keepFields,
            global::System.Collections.Generic.IList<string>? optionalFields,
            string? textSeparator,
            string? csvDelimiter,
            string? xClientName,
            global::G.CreateDatasetRequest request);
        partial void ProcessCreateDatasetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateDatasetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a Dataset<br/>
        /// Create a dataset by uploading a file. See ['Dataset Creation'](https://docs.cohere.com/docs/datasets#dataset-creation) for more information.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the dataset
        /// </param>
        /// <param name="keepOriginalFile"></param>
        /// <param name="skipMalformedInput"></param>
        /// <param name="keepFields"></param>
        /// <param name="optionalFields"></param>
        /// <param name="textSeparator"></param>
        /// <param name="csvDelimiter"></param>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateDatasetResponse> CreateDatasetAsync(
            string name,
            global::G.DatasetType type,
            global::G.CreateDatasetRequest request,
            bool? keepOriginalFile = default,
            bool? skipMalformedInput = default,
            global::System.Collections.Generic.IList<string>? keepFields = default,
            global::System.Collections.Generic.IList<string>? optionalFields = default,
            string? textSeparator = default,
            string? csvDelimiter = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateDatasetArguments(
                httpClient: HttpClient,
                name: ref name,
                type: ref type,
                keepOriginalFile: ref keepOriginalFile,
                skipMalformedInput: ref skipMalformedInput,
                keepFields: keepFields,
                optionalFields: optionalFields,
                textSeparator: ref textSeparator,
                csvDelimiter: ref csvDelimiter,
                xClientName: ref xClientName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/datasets",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("name", name) 
                .AddRequiredParameter("type", type.ToValueString()) 
                .AddOptionalParameter("keep_original_file", keepOriginalFile?.ToString()) 
                .AddOptionalParameter("skip_malformed_input", skipMalformedInput?.ToString()) 
                .AddOptionalParameter("keep_fields", keepFields, delimiter: ",", explode: true) 
                .AddOptionalParameter("optional_fields", optionalFields, delimiter: ",", explode: true) 
                .AddOptionalParameter("text_separator", textSeparator) 
                .AddOptionalParameter("csv_delimiter", csvDelimiter) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (xClientName != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{name}"),
                name: "name");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{type.ToValueString()}"),
                name: "type");
            if (keepOriginalFile != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{keepOriginalFile}"),
                    name: "keep_original_file");
            } 
            if (skipMalformedInput != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{skipMalformedInput}"),
                    name: "skip_malformed_input");
            } 
            if (keepFields != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(keepFields, x => x))}]"),
                    name: "keep_fields");
            } 
            if (optionalFields != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(optionalFields, x => x))}]"),
                    name: "optional_fields");
            } 
            if (textSeparator != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{textSeparator}"),
                    name: "text_separator");
            } 
            if (csvDelimiter != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{csvDelimiter}"),
                    name: "csv_delimiter");
            } 
            if (xClientName != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xClientName}"),
                    name: "X-Client-Name");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.Data ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "data",
                fileName: request.Dataname ?? string.Empty);
            if (request.EvalData != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.ByteArrayContent(request.EvalData ?? global::System.Array.Empty<byte>())
                    {
                        Headers =
                        {
                            ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                        },
                    },
                    name: "eval_data",
                    fileName: request.EvalDataname ?? string.Empty);
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateDatasetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                name: name,
                type: type,
                keepOriginalFile: keepOriginalFile,
                skipMalformedInput: skipMalformedInput,
                keepFields: keepFields,
                optionalFields: optionalFields,
                textSeparator: textSeparator,
                csvDelimiter: csvDelimiter,
                xClientName: xClientName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateDatasetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateDatasetResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.CreateDatasetResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a Dataset<br/>
        /// Create a dataset by uploading a file. See ['Dataset Creation'](https://docs.cohere.com/docs/datasets#dataset-creation) for more information.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the dataset
        /// </param>
        /// <param name="keepOriginalFile"></param>
        /// <param name="skipMalformedInput"></param>
        /// <param name="keepFields"></param>
        /// <param name="optionalFields"></param>
        /// <param name="textSeparator"></param>
        /// <param name="csvDelimiter"></param>
        /// <param name="xClientName"></param>
        /// <param name="data">
        /// The file to upload
        /// </param>
        /// <param name="dataname">
        /// The file to upload
        /// </param>
        /// <param name="evalData">
        /// An optional evaluation file to upload
        /// </param>
        /// <param name="evalDataname">
        /// An optional evaluation file to upload
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateDatasetResponse> CreateDatasetAsync(
            string name,
            global::G.DatasetType type,
            byte[] data,
            string dataname,
            bool? keepOriginalFile = default,
            bool? skipMalformedInput = default,
            global::System.Collections.Generic.IList<string>? keepFields = default,
            global::System.Collections.Generic.IList<string>? optionalFields = default,
            string? textSeparator = default,
            string? csvDelimiter = default,
            string? xClientName = default,
            byte[]? evalData = default,
            string? evalDataname = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateDatasetRequest
            {
                Data = data,
                Dataname = dataname,
                EvalData = evalData,
                EvalDataname = evalDataname,
            };

            return await CreateDatasetAsync(
                name: name,
                type: type,
                keepOriginalFile: keepOriginalFile,
                skipMalformedInput: skipMalformedInput,
                keepFields: keepFields,
                optionalFields: optionalFields,
                textSeparator: textSeparator,
                csvDelimiter: csvDelimiter,
                xClientName: xClientName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}