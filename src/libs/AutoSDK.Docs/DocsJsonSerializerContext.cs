using System.Text.Json.Serialization;
using AutoSDK.Models;

namespace AutoSDK.Docs;

[JsonSourceGenerationOptions(PropertyNameCaseInsensitive = true)]
[JsonSerializable(typeof(DocsConfig))]
[JsonSerializable(typeof(GeneratedSdkSnippetManifest))]
internal sealed partial class DocsJsonSerializerContext : JsonSerializerContext;
